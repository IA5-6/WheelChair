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
        JsonDataMessage message;
        public Form1()
        {
            InitializeComponent();
            communication = new Communication("COM3",115200);
            communication.dataIsReady += new EventHandler(dealWithDataReady);
            message = new JsonDataMessage();
        }

        private void dealWithDataReady(object sender, EventArgs e)
        {
            ///Here all the logging and alarm checking can be done
            JsonDataMessage toBeChecked = communication.latestMessage;
            

        }
    }
}
