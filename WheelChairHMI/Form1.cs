using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Newtonsoft.Json;
using System.Reflection;

namespace WheelChairHMI
{
    public partial class Form1 : Form
    {
        ArduinoComClass com;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            com = new ArduinoComClass("COM19", 115200);
            com.Open();
        }
        JsonMessage message = new JsonMessage();
        Communication communication = new Communication();

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            btnAlarm.Text = ("⚠🛑 Alarms ⚠🛑");
            btnAlarm.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (com.dataReady)
            {
                label4.Text = com.recievedData;
                com.dataReady = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (com.IsOpen)
            {
                com.WriteLine(communication.ClassToJson(message));
            }
        }
    }
    class ArduinoComClass : SerialPort
    {
        public string recievedData;
        public bool dataReady;
        public ArduinoComClass(string comport, int baudrate)
        {
            PortName = comport;
            BaudRate = baudrate;
            DataReceived += new SerialDataReceivedEventHandler(dataRecieved);
            ReadTimeout = 2000;
            dataReady = false;
        }

        public void dataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                recievedData = ReadLine();
                dataReady = true;
                JsonMessage msg = JsonConvert.DeserializeObject<JsonMessage>(recievedData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dataReady = false;
            }
        }
    }
}
