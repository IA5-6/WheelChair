﻿using System;
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


       /* DB_Handling dB = new DB_Handling("Data Source=localhost\\" +
                "SQLEXPRESS01;Initial Catalog=Wheelchair;Integrated Security=True");*/
        readonly Communication communication;
        readonly ButtonHandling btnHandling;
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = dB.ViewAlarmHistory();
            communication = new Communication(cboComPort,btnSerialConnect,115200);
            communication.dataIsReady += new EventHandler(DealWithDataReady);
            btnHandling = new ButtonHandling(communication);
            KeyPreview = true;//Needs to be true to detect button presses
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            btnHandling.ProcessBtnClick(keyData);
            return true;
        }
        

        private void DealWithDataReady(object sender, EventArgs e)
        {
            ///Here all the logging and alarm checking can be done
            JsonDataMessage toBeChecked = communication.LatestMessage;
            //MessageBox.Show(toBeChecked.Speed.ToString());
            
            
        }
    }
    
}
