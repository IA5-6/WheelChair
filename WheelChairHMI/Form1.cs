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

namespace WheelChairHMI
{
    public partial class Form1 : Form
    {
        DB_Handling dB = new DB_Handling("Data Source=localhost\\" +
                "SQLEXPRESS01;Initial Catalog=Wheelchair;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = dB.ViewAlarmHistory();
        }

        

        
    }
    
}
