﻿using System;
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
        private string recievedData;
        private bool dataReady;
        private JsonDataMessage lastMsg;
        private string[] ports = GetPortNames();
        /// <summary>
        /// Event handler that triggers when a serial port message is recieved
        /// </summary>
        public EventHandler dataIsReady;
        #endregion
        /// <summary>
        /// Constructor for initializing the communication Class
        /// </summary>
        /// <param name="comport">String specifying the comport to the arduino. ex. "COM1"</param>
        /// <param name="baudrate">The baudrate of the comport</param>
        public Communication(string comport, int baudrate)
        {
            PortName = comport;
            BaudRate = baudrate;
            DataReceived += new SerialDataReceivedEventHandler(dataRecieved);
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
        public Communication(ComboBox cbo, Button button)
        {
            button.Click += new EventHandler(btnConnectClick);
            cbo.Items.AddRange(ports);
            cbo.SelectedIndex=0;
        }
        #region Event methods
        private void btnConnectClick(object sender, EventArgs e) 
        {
            try
            {
                Button btn = sender as Button;
                if (IsOpen)
                {
                    Close();
                    btn.Text = "Connect";
                }
                else
                {
                    Open();
                    btn.Text = "Disconnect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error When Connecting");
            }
            
        }
        private void dataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                recievedData = ReadLine();
                lastMsg = JsonConvert.DeserializeObject<JsonDataMessage>(recievedData);
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
        public void ConnectPort(string comport, int baudrate)
        {

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
        public void sendObjViaSerial(JsonCommandMessage msg)
        {
            string temp = ClassToJson(msg);
            if (!this.IsOpen)
            {
                this.Open();
            }
            this.WriteLine(temp);
        }
        #endregion
        #region Properties
        /// <summary>
        /// Gets the latest message object of the latestMessage class
        /// </summary>
        public JsonDataMessage latestMessage {//Property to get the latest JsonMessage that is recieved
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
