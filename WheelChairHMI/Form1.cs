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

namespace WheelChairHMI
{
    public partial class Form1 : Form
    {

        //DB_Handling dB = new DB_Handling("Data Source=localhost\\" +
             //   "SQLEXPRESS01;Initial Catalog=Wheelchair;Integrated Security=True");
      //  Communication communication;
        JsonDataMessage message;
        Alarm alarmCollection;
        public Form1()
        {
            InitializeComponent();
            //communication = new Communication("COM3",115200);
            //communication.dataIsReady += new EventHandler(dealWithDataReady);
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
        private void UpdateAlarms(object o, EventArgs e)
        {
            dgvActiceAlarms.DataSource = dB.ViewsFromDatabase("ViewActiveAlarms");
            dgvAlarmHistory.DataSource = dB.ViewsFromDatabase("ViewAlarmHistory");
        }

        private void btnAckAlarms_Click(object sender, EventArgs e)
        {
            dB.UpdateAlarm();
            dB.AckAlarms();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            dB.LogAlarms(1, rand.NextDouble()*100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dB.LogAlarms(rand.Next(1, 7), rand.NextDouble() * 100);
        }

        private void btnUpdateAlarms_Click(object sender, EventArgs e)
        {
            dB.UpdateAlarm();


             

        }

        
    }
    
}
