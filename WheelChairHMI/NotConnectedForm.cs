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
            
        }
       


        private void btnConnect_Click(object sender, EventArgs e)
        {
            Com.BtnConnectClick(sender, e);
            if (Com.IsOpen)
            {
            this.DialogResult = DialogResult.OK;
            this.Close();

            }
        }

        private void notConnectedForm_Shown(object sender, EventArgs e)
        {
            Com.Cbo = cboCom;
            Com.populateCbo();
        }
    }
}
