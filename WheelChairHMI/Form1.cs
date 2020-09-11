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

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            btnAlarm.Text = ("⚠🛑 Alarms ⚠🛑");
            btnAlarm.BackColor = Color.Red;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string key = "";
            switch (e.KeyData)
            {
                case Keys.Up:
                    key = "Up Arrow";
                    break;
                case Keys.Down:
                    key = "Down Arrow";
                    break;
                case Keys.Left:
                    key = "Left arrow";
                    break;
                case Keys.Right:
                    key = "Right arrow";
                    break;
                default:
                    key = "Den knappen støtter jeg ikke";
                    break;
            }
            MessageBox.Show(key);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Hoe");
        }
    }
}
