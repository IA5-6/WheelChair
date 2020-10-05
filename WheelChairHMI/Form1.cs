using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

using System.Windows.Input;

using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;


namespace WheelChairHMI
{
    public partial class Form1 : Form
    {


        DB_Handling dB = new DB_Handling("Data Source=localhost\\" + "SQLEXPRESS01;Initial Catalog=Wheelchair;Integrated Security=True");
        JsonDataMessage message;
        Alarm alarmCollection;
        readonly Communication communication;
        readonly ButtonHandling btnHandling;
        public Form1()
        {
            InitializeComponent();
            communication = new Communication(cboComPort,btnSerialConnect,115200);
            communication.dataIsReady += new EventHandler(dealWithDataReady);
            btnHandling = new ButtonHandling(communication);
            KeyPreview = true;//Needs to be true to detect button presses
            message = new JsonDataMessage();
            dB.UpdateAlarms += new EventHandler(UpdateAlarms);
            dB.UpdateAlarm();
            alarmCollection= new Alarm();
        }
        private void dealWithDataReady(object sender, EventArgs e)
        {
            ///Here all the logging and alarm checking can be done
            JsonDataMessage toBeChecked = communication.latestMessage;

            alarmCollection.AlarmCheck(message); //Sending the values from arduino to alarmclass

            

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            btnHandling.ProcessBtnClick(keyData);
            return true;
        }
        private void UpdateAlarms(object o, EventArgs e)
        {
            dataGridViewAlarms.DataSource = dB.ViewsFromDatabase("viewallalarmsorderd");
            
            
        }
        
        private void btnAckAlarms_Click(object sender, EventArgs e)
        {
            dB.AckAlarms();
            dB.UpdateAlarm();
        }
        /// <summary>
        /// Test button for logging alarms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dB.LogAlarms(1, rand.NextDouble() * 100);
        }
        /// <summary>
        /// Test button for logging data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dB.LogData(rand.Next(1, 3), rand.NextDouble() * 100);
        }
        //Event for updating the alarms manually.
        private void btnUpdateAlarms_Click(object sender, EventArgs e)
        {
            dB.UpdateAlarm();


             

        }

        //Event for updatning historical data to the data grid view manually
        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dB.ViewsFromDatabase("ViewDataHistory");
        }

    }
    
}
