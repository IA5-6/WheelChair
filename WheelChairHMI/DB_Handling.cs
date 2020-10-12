using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WheelChairHMI
{
    //The main database handling class for this project.
    /// <summary>
    /// Contains a variaty of methods for communicating with a SQL database.
    /// 
    /// </summary>
    class DB_Handling
    {
        #region Properties

        private string DBConfig { get; set; }
        public DateTime Timestamp { get; set; }
        //public List<string> AlarmHistory { get; set; } = new List<string>();
        /// <summary>
        /// Event for updating active and historical alarms.
        /// </summary>
        public event EventHandler UpdateAlarms;
        
        #endregion

        #region Constructors
        public DB_Handling(string config)
        {
            DBConfig = config;
        }
        #endregion

        #region Testing
        //Test funksjon
        public void CnnDB()
        {
            string sqlQuery;
            try
            {
                SqlConnection cnn = new SqlConnection(DBConfig);
                sqlQuery = String.Concat(@"INSERT INTO Timestamp
                        VALUES ('",Timestamp,"'");
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

        #region Private Methods
        //Method for creating new sql connection
        private SqlConnection DBcon()
        {
            return new SqlConnection(DBConfig);
        }
        //Method for sending a command to the database.
        /// <summary>
        /// Method for sending a command to the database.
        /// </summary>
        /// <param name="commandstring">The commanda you wish to send to the database.</param>
        private void SendCommand(string commandstring)
        {
            try
            {
                using (SqlConnection con = DBcon())
                {
                    using (SqlCommand cmd = new SqlCommand(commandstring, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        #endregion

        #region Public methods
        //Method for logging data
        /// <summary>
        /// Logs different types of data to the database.
        /// Currentlys there are three types of data.
        /// 1: Remaining batterytime,2: Total distance travled and 3: Top speed achived.
        /// </summary>
        /// <param name="dataId">The id that represent diffrent types of data.</param>
        /// <param name="dataval">The value of data to be stored.</param>
        public void LogData(int dataId, double dataVal)
        {
            Timestamp = DateTime.Now;
            try
            {
                using (SqlConnection con = DBcon())
                {
                    using (SqlCommand cmd = new SqlCommand("Insert into Timestamp values (@c1)" +
                        "Insert into Data values(@c2,@c3,@c4)", con))
                    {
                        cmd.Parameters.AddWithValue("@c1", Timestamp);
                        cmd.Parameters.AddWithValue("@c2", Timestamp);
                        cmd.Parameters.AddWithValue("@c3", dataId);
                        cmd.Parameters.AddWithValue("c4", dataVal);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            
        }
        //Method for clearing a table
        /// <summary>
        /// Method for deleting data from three tables Data, Alarms and Timestamp
        /// </summary>
        public void ClearTables()
        {
            string Query;
            Query = String.Concat(@"delete from Data
                delete from Alarms
                alter table Data nocheck constraint all
                alter table Alarms nocheck constraint all
                delete from Timestamp
                alter table Data check constraint all
                alter table Data check constraint all");
            SendCommand(Query);
        }
        //Method for logging alarms.
        /// <summary>
        /// Method for logging alarms to database.
        /// Currentlyg there are seven types of alarms.
        /// 1: Emergency stop activated.
        /// 2: High speed.
        /// 3-6: Different types of zones activated, starts with zone 1.
        /// 7: Low battery.
        /// </summary>
        /// <param name="AlarmId">Id to determine which alarm is to be logged.</param>
        /// <param name="Alarmvalue"></param>
        public void LogAlarms(int AlarmId, double Alarmvalue)
        {
            Timestamp = DateTime.Now;
            try
            {
                using (SqlConnection con = DBcon())
                {
                    using (SqlCommand cmd = new SqlCommand("insert into Timestamp values(@col)" +
                    "insert into Alarms values(@col1,@col2,@col3,@col4)",con))
                    {
                        cmd.Parameters.AddWithValue("@col", Timestamp);
                        cmd.Parameters.AddWithValue("@col1", Timestamp);
                        cmd.Parameters.AddWithValue("@col2", AlarmId);
                        cmd.Parameters.AddWithValue("@col3", Alarmvalue);
                        cmd.Parameters.AddWithValue("@col4", 0);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //Method for obtaining data table of alarms.
        /// <summary>
        /// There are three views in the database right now. To get a view, write the name of a procedure wich selects data.
        /// To get alarm history write ViewAlarmHistory.
        /// To get active alarms write ViewActiveAlarms.
        /// To get data history write ViewDataHistory.
        /// The method will return a DataTable with either alarmhistory or active alarms.
        /// </summary>
        /// <returns></returns>
        public DataTable ViewsFromDatabase(string View)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection sqlConnection = DBcon();
                SqlCommand cmd = new SqlCommand(View, sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlConnection.Open();
                dt.Load(cmd.ExecuteReader());
                sqlConnection.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            return dt;
        }
        //Method that returns a list of all contents in a table. 
        /// <summary>
        /// Method that returs a list of all content in a table. 
        /// Each row is one element in the list, each column is comma separated.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<string> GetLists(string table)
        {
            List<string> vs = new List<string>();
            List<string> temp = new List<string>();
            string q,s;
            q = String.Concat(@"select * from ",table);
            try
            {
                SqlCommand cmd = new SqlCommand(q, DBcon())
                {
                    CommandType = CommandType.Text
                };
                DBcon().Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < dr.ItemArray.Length; i++)
                    {
                        temp.Add(dr[i].ToString());
                    }
                    s = string.Join(",", temp);
                    vs.Add(s);
                    temp.Clear();
                    s = "";
                }
                DBcon().Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            return vs;
        }
        //Method for activating the UpdateAlarms event.
        /// <summary>
        /// Method for activating the UpdateAlarms event.
        /// </summary>
        public void RunUpdateAlarm()
        {
            UpdateAlarms(this, new EventArgs());
        }
        //Method for acknowledgeing all unacknowledge alarms.
        /// <summary>
        /// Method that calls up a procedure, which alters the acked value to 1 for all unacked alarms.
        /// </summary>
        public void AckAlarms()
        {
            SendCommand("AckAllAlarms");
        }
        #endregion


    }
}
