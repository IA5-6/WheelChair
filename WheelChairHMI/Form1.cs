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

        DB_Handling dB = new DB_Handling("Data Source=localhost\\" +
                "SQLEXPRESS01;Initial Catalog=Wheelchair;Integrated Security=True");
        Communication communication;
        JsonDataMessage message;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = dB.ViewAlarmHistory();
            communication = new Communication("COM3",115200);
            communication.dataIsReady += new EventHandler(dealWithDataReady);
            message = new JsonDataMessage();
            this.KeyPreview = true;

        }

        private void dealWithDataReady(object sender, EventArgs e)
        {
            ///Here all the logging and alarm checking can be done
            JsonDataMessage toBeChecked = communication.latestMessage;
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
