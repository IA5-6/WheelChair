using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WheelChairHMI
{
    class DB_Handling
    {
        public string DBConfig { get; set; }
        public DateTime Timestamp { get; set; }

        public DB_Handling(string config)
        {
            DBConfig = config;
        }
        #region Methods
        //Test funksjon
        public void CnnDB()
        {
            string data, sqlQuery;
            try
            {
                SqlConnection cnn = new SqlConnection(DBConfig);
                DateTime time = DateTime.Now;
                data = "Test";
                sqlQuery = String.Concat(@"INSERT INTO Timestamp
                        VALUES ('",time,"','",data,"')");
                cnn.Open();
                SqlCommand command = new SqlCommand(sqlQuery, cnn);
                command.ExecuteNonQuery();
                cnn.Close();



            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            
        }
        #endregion

    }
}
