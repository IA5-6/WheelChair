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
        private string recievedData;
        private bool dataReady;
        private JsonMessage lastMsg;
        public Communication(string comport, int baudrate)
        {
            PortName = comport;
            BaudRate = baudrate;
            DataReceived += new SerialDataReceivedEventHandler(dataRecieved);
            ReadTimeout = 2000;
            dataReady = false;
            this.Open();
        }

        public void dataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                recievedData = ReadLine();
                lastMsg = JsonConvert.DeserializeObject<JsonMessage>(recievedData);
                dataReady = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dataReady = false;
            }
        }

        private string ClassToJson(JsonMessage msg)
        {
            string json = JsonConvert.SerializeObject(msg);
            return json;
        }
        public void sendObjViaSerial(JsonMessage msg)
        {
            string temp = ClassToJson(msg);
            if (!this.IsOpen)
            {
                this.Open();
            }
            this.WriteLine(temp);
            //this.Close();
        }
        /// <summary>
        /// Gets the latest message object of the latestMessage class
        /// </summary>
        public JsonMessage latestMessage {//Property to get the latest JsonMessage that is recieved
            get
            {
                if (lastMsg != null)
                {
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
    }
}
