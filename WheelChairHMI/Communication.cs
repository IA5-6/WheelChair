using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO.Ports;
using System.Windows.Forms;

namespace WheelChairHMI
{
        /// <summary>
        /// Handling sending, recieving and parsing of the Serial communication
        /// to/from the arduino
        /// </summary>
    class Communication:SerialPort
    {
        #region Fields 
        private int turningSpeed = 30;
        private string recievedData;
        private bool dataReady;
        private JsonDataMessage lastMsg;
        private JsonCommandMessage cmdMsg;
        private string[] ports = GetPortNames();
        internal  ComboBox Cbo;
        private readonly ComboBox cboParent;//For putting back in Cbo when returning from NotConnectedForm
        internal  Button ConnectButton;
        private notConnectedForm form;//Form for choosing comport if not chosen
        private int Speed = 0;
        /// <summary>
        /// Event handler that triggers when a serial port message is recieved
        /// </summary>
        public EventHandler dataIsReady;
        #endregion
        #region Constructors
        /// <summary>
        /// Legacy constructor for initializing the communication Class
        /// </summary>
        /// <param name="comport">String specifying the comport to the arduino. ex. "COM1"</param>
        /// <param name="baudrate">The baudrate of the comport</param>
        public Communication(string comport, int baudrate)
        {
            PortName = comport;
            BaudRate = baudrate;
            DataReceived += new SerialDataReceivedEventHandler(DataRecieved);
            ReadTimeout = 5000;
            dataReady = false;
            try
            {
                this.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error opening the port");
            }

        }
        /// <summary>
        /// Constructor for working with a cbo filled with the available serial ports and a button for connecting.
        /// </summary>
        /// <param name="cbo">Combobox for choosing Comport</param>
        /// <param name="button">Button for connecting and disconnecting</param>
        /// <param name="baudRate">Integer denoting the baudrate of serial comms</param>
        public Communication(ComboBox cbo, Button button,int baudRate)
        {
            BaudRate = baudRate;
            ReadTimeout = 2000;
            WriteTimeout = 2000;
            dataReady = false;
            ConnectButton = button;//Assigns the connect button to the field
            DataReceived += new SerialDataReceivedEventHandler(DataRecieved);//Event handler for handling serial data recieved
            ConnectButton.Click += new EventHandler(BtnConnectClick);//Click event for the connect button
            cboParent = cbo;
            Cbo = cbo;
            Cbo.Items.AddRange(ports);
            Cbo.SelectedIndex=0;
            form = new notConnectedForm(this);
            form.FormClosed += new FormClosedEventHandler(closedForm);
            cmdMsg = new JsonCommandMessage();
        }
        #endregion
        #region Event methods
        


        private void closedForm(object sender, FormClosedEventArgs e)
        {
            Cbo = cboParent;
            
        }
        internal void BtnConnectClick(object sender, EventArgs e) 
        {
            try
            {
                //Button btn = sender as Button;
                if (IsOpen)
                {
                    DisconnectPort();
                }
                else
                {
                    ConnectPort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error When Connecting");
            }
            
        }
        private void DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                recievedData = ReadLine();
                lastMsg = JsonConvert.DeserializeObject<JsonDataMessage>(recievedData);
                if (!lastMsg.Zone1Tripped)
                {
                    Speed = lastMsg.Speed;
                }
                else
                {
                    Speed = 0;
                }
                dataReady = true;
                dataIsReady(this, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"dataRecieved error");
                dataReady = false;
            }
        }
        #endregion
        #region Methods
        #region DriveMethods
        public void DriveForward()
        {
            cmdMsg.Left = false;
            cmdMsg.Right = false;
            if (Speed < 0)
            {
                cmdMsg.Drive = false;
                cmdMsg.Speed = 0;
            }
            else if(Speed>=0)
            {
                if (!lastMsg.Zone1Tripped)
                {
                cmdMsg.Drive = true;
                cmdMsg.Speed += 15;

                }
            }
        }
        public void DriveBack()
        {
            cmdMsg.Left = false;
            cmdMsg.Right = false;
            if (Speed >0)
            {
                cmdMsg.Drive = false;
                cmdMsg.Speed = 0;
            }
            else if(Speed<=0)
            {
                cmdMsg.Drive = true;
                cmdMsg.Speed -= 15;
            }
        }
        public void TurnLeft()
        {
            cmdMsg.Drive = true;
            cmdMsg.Speed = turningSpeed;
            cmdMsg.Left = true;
            cmdMsg.Right = false;
        }
        public void TurnRight()
        {
            cmdMsg.Drive = true;
            cmdMsg.Speed = turningSpeed;
            cmdMsg.Right = true;
            cmdMsg.Left = false;
        }
        #endregion
        public void ConnectPort()
        {
            
            PortName = Cbo.SelectedItem.ToString();
            Open();
            ReadExisting();
            ConnectButton.Text = "Disconnect";
        }
        internal void DisconnectPort()
        {
            cmdMsg.Drive = false;
            cmdMsg.Speed = 0;
            Close();
            ConnectButton.Text = "Connect";
        }

        internal void populateCbo()
        {
            ports = GetPortNames();
            Cbo.Items.AddRange(ports);
            Cbo.SelectedIndex = 0;
        }
        
        private string ClassToJson(JsonCommandMessage msg)
        {
            string json = JsonConvert.SerializeObject(msg);
            return json;
        }

        /// <summary>
        /// Used for sending an object of class JsonCommandMessage over serial to the chosen COM port 
        /// </summary>
        /// <param name="msg">Object of the JsonCommandMessage format</param>
        public void SendObjViaSerial(JsonCommandMessage msg)
        {
            string temp = ClassToJson(msg);
            if (!this.IsOpen)
            {
                form.ShowDialog();
            }
            try
            {
                this.WriteLine(temp);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error When writing to " + this.PortName);
            }
        }
        public void SendObjViaSerial()
        {
            string temp = ClassToJson(cmdMsg);
            if (!this.IsOpen)
            {
                form.ShowDialog();
            }
            try
            {
                this.WriteLine(temp);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error When writing to " + this.PortName);
            }
        }
        #endregion
        #region Properties
        /// <summary>
        /// Gets the latest message object of the latestMessage class
        /// </summary>
        public JsonDataMessage LatestMessage {//Property to get the latest JsonMessage that is recieved
            get
            {
                if (lastMsg != null)
                {
                    dataReady = false;
                    return lastMsg;
                }
                else
                {
                    throw new Exception("There is no latest message");
                }
            } 
        }
        /// <summary>
        /// Gets the data ready flag
        /// </summary>
        public bool DataReady
        {
            get { return dataReady; }
        }
        #endregion
    }
}
