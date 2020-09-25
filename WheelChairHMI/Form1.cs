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
            /*  dataGridView1.DataSource = dB.ViewAlarmHistory();
              communication = new Communication("COM3",115200);
              communication.dataIsReady += new EventHandler(dealWithDataReady);*/
            message = new JsonDataMessage();
            alarmCollection= new Alarm();
        }

        private void dealWithDataReady(object sender, EventArgs e)
        {
            ///Here all the logging and alarm checking can be done
            JsonDataMessage toBeChecked = communication.latestMessage;

            alarmCollection.AlarmCheck(message);
        }

        
    }
    
}
