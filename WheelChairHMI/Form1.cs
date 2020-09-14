using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WheelChairHMI
{
    public partial class Form1 : Form
    {
       
        Communication communication;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            communication = new Communication("COM3",115200);
        }
        JsonMessage message = new JsonMessage();

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            btnAlarm.Text = ("⚠🛑 Alarms ⚠🛑");
            btnAlarm.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            message.Speed = 89;
            communication.sendObjViaSerial(message);
        }
    }
}
