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
        JsonDataMessage message;
        Alarm alarmCollection;
        readonly Communication communication;
        readonly ButtonHandling btnHandling;
        DataHandling dataHandling = new DataHandling(true, "Data Source=localhost\\" + 
            "SQLEXPRESS01;Initial Catalog=Wheelchair;Integrated Security=True");
        private bool DriveEnabled;
        public Form1()
        {
            InitializeComponent();
            communication = new Communication(cboComPort,btnSerialConnect,115200);
            communication.dataIsReady += new EventHandler(dealWithDataReady);
            btnHandling = new ButtonHandling(communication);
            KeyPreview = true;//Needs to be true to detect button presses
            message = new JsonDataMessage();
            dataHandling.UpdateAlarms += new EventHandler(UpdateAlarms);//Event that updates alarm
            dataHandling.RunUpdateAlarm();
            dataHandling.UpdateData += new EventHandler(UpdateData);//Event that updayes alarm
            dataHandling.RunUpdateData();
            alarmCollection= new Alarm();
            InitEvents();
            tmrLogData.Start();
            //tmrUpdateAlarms.Start();
            //tmrUpdateData.Start();
            tmrAlarmActive.Start();
            DriveEnabled = false;
            
        }
        private void dealWithDataReady(object sender, EventArgs e)
        {
            try
            {
                ///Here all the logging and alarm checking can be done
                JsonDataMessage toBeChecked = communication.LatestMessage;
                alarmCollection.AlarmCheck(toBeChecked); //Sending the values from arduino to alarmclass
                dataHandling.SendData(toBeChecked);
                ZoneHandling(toBeChecked);
                //UpdateAlarmPic();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (DriveEnabled)
            {
                btnHandling.ProcessBtnClick(keyData);
                Arrowhandling(keyData);
            }
            return true;
        }

        #region Buttonevents
        private void UpdateAlarms(object o, EventArgs e)
        {
            dataGridViewAlarms.DataSource = dataHandling.ViewsFromDatabase("viewallalarmsorderd");
        }
        private void UpdateData(object o,EventArgs e)
        {
            dgvData.DataSource = dataHandling.ViewsFromDatabase("ViewDataHistory");
        }
        private void btnAckAlarms_Click(object sender, EventArgs e)
        {
            alarmCollection.alarmBoolList();
            dataHandling.AckAlarms();
            dataHandling.RunUpdateAlarm();
        }
        private void btnEnableDriving_Click(object sender, EventArgs e)
        {
            DriveEnabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            DriveEnabled = false;
        }
        #endregion

        #region TestRegion
        /// <summary>
        /// Test button for logging alarms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dataHandling.LogAlarms(1, rand.NextDouble() * 100);

        }
        /// <summary>
        /// Test button for logging data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dataHandling.LogData(rand.Next(1, 3), rand.NextDouble() * 100);
        }

        #endregion

        #region DataGridViews
        //Event for updating the alarms manually.
        private void btnUpdateAlarms_Click(object sender, EventArgs e)
        {
            dataHandling.RunUpdateAlarm();
        }
        //Event for updatning historical data to the data grid view manually
        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            dataHandling.RunUpdateData();
        }
        #endregion

        #region Alarmevents
        private void emergencyAlarm(object sender, EventArgs e)
        {
            dataHandling.LogAlarms(1,1);
        }
        private void speedAlarm(object sender, EventArgs e)
        {
            dataHandling.LogAlarms(2,communication.LatestMessage.Speed);
        }
        private void zone1Active(object sender, EventArgs e)
        {
            dataHandling.LogAlarms(3,1);
        }
        private void zone2Active(object sender, EventArgs e)
        {
            dataHandling.LogAlarms(4,1);
        }
        private void zone3Active(object sender, EventArgs e)
        {
            dataHandling.LogAlarms(5,1);
        }
        private void zone4Active(object sender, EventArgs e)
        {
            dataHandling.LogAlarms(6,1);
        }
        private void batteryAlarm(object sender, EventArgs e)
        {
            dataHandling.LogAlarms(7,communication.LatestMessage.BatteryLevel);
        }
        #endregion

        #region Datahandling

        public void Arrowhandling(Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    picBoxFwd.Visible = true;
                    picBoxBwd.Visible = false;
                    picBoxLeft.Visible = false;
                    picBoxRight.Visible = false;
                    break;
                case Keys.Down:
                    picBoxFwd.Visible = false;
                    picBoxBwd.Visible = true;
                    picBoxLeft.Visible = false;
                    picBoxRight.Visible = false;
                    break;
                case Keys.Right:
                    picBoxFwd.Visible = false;
                    picBoxBwd.Visible = false;
                    picBoxLeft.Visible = false;
                    picBoxRight.Visible = true;
                    break;
                case Keys.Left:
                    picBoxFwd.Visible = false;
                    picBoxBwd.Visible = false;
                    picBoxLeft.Visible = true;
                    picBoxRight.Visible = false;
                    break;
            }
        }
        
        
        /// <summary>
        /// Method that checks wether
        /// </summary>
        /// <param name="json"></param>
        private void ZoneHandling(JsonDataMessage json)
        {
            if (json.Zone1Tripped)
            {
                zone1.BackColor = Color.DarkGray;
            }
            else
            {
                zone1.BackColor = Color.White;
            }
            if (json.Zone2Tripped)
            {
                zone2.BackColor = Color.DarkGray;
            }
            else
            {
                zone2.BackColor = Color.White;
            }
            if (json.Zone3Tripped)
            {
                zone3.BackColor = Color.DarkGray;
            }
            else
            {
                zone3.BackColor = Color.White;
            }
            if (json.Zone4Tripped)
            {
                zone4.BackColor = Color.DarkGray;
            }
            else
            {
                zone4.BackColor = Color.White;
            }
            
        }
        
        #endregion

        #region Methods
        public void InitEvents()
        {
            alarmCollection.Battery += new EventHandler(batteryAlarm);
            alarmCollection.Emergency += new EventHandler(batteryAlarm);
            alarmCollection.Speed += new EventHandler(speedAlarm);
            alarmCollection.ZoneActive1 += new EventHandler(zone1Active);
            alarmCollection.ZoneActive2 += new EventHandler(zone2Active);
            alarmCollection.ZoneActive3 += new EventHandler(zone3Active);
            alarmCollection.ZoneActive4 += new EventHandler(zone4Active);
        }
        public void UpdateAlarmPic()
        {
            if (dataHandling.CountActiveAlarms() > 0)
            {
                picBoxAlarm.Visible = true;
            }
            else
            {
                picBoxAlarm.Visible = false;
            }
        }
        #endregion

        #region Timers

        private void tmrLogData_Tick(object sender, EventArgs e)
        {
            dataHandling.LogDataBit = true;
        }
        private void tmrUpdateAlarms_Tick(object sender, EventArgs e)
        {
            dataHandling.RunUpdateAlarm();
        }
        private void tmrUpdateData_Tick(object sender, EventArgs e)
        {
            dataHandling.RunUpdateData();
        }
        private void tmrAlarmActive_Tick(object sender, EventArgs e)
        {
            UpdateAlarmPic();
        }

        #endregion
    }


}
