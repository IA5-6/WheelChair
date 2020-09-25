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
    partial class notConnectedForm : Form
    {
        private Communication Com; 
        public notConnectedForm()
        {
            InitializeComponent();
        }
        public notConnectedForm(Communication com)
        {
            InitializeComponent();
            Com = com;
            com.populateCbo(cboCom);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Com.btnConnectClick(sender, e);
        }
    }
}
