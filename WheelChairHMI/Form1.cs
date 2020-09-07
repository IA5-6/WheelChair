using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelChairHMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        JsonMessage message = new JsonMessage();
        Communication communication = new Communication();

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            btnAlarm.Text = ("⚠🛑 Alarms ⚠🛑");
            btnAlarm.BackColor = Color.Red;
        }
    }
}
