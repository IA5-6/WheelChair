using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WheelChairHMI
{
    /*
     The main database handling class for this project.
         */

    /// <summary>
    /// Contains a variaty of methods for communicating with a SQL database.
    /// 
    /// </summary>
    class DB_Handling
    {
        #region Properties

        public string DBConfig { get; set; }
        public DateTime Timestamp { get; set; }
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
            string data, sqlQuery;
            try
            {
                SqlConnection cnn = new SqlConnection(DBConfig);
                data = "Test";
                sqlQuery = String.Concat(@"INSERT INTO Timestamp
                        VALUES ('",Timestamp,"','",data,"')");
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
        //Method for sending Query statements to sql.
        /// <summary>
        /// This methods sends query command to the db.
        /// </summary>
        /// <param name="Q">The desiered sql query</param>
        private void CnnSendCommand(string Q)
        {
            try
            {
                SqlConnection cnn = DBcon();
                cnn.Open();
                SqlCommand command = new SqlCommand(Q, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
        public void LogData(double dataval, int dataId)
        {
            string Query;
            Timestamp = DateTime.Now;
            Query = String.Concat(@"INSERT INTO Timestamp VALUES ('", Timestamp, "')"
                + "INSERT INTO Data Values('", Timestamp, "','", dataId, "','",dataval,"')");
            CnnSendCommand(Query);
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
            CnnSendCommand(Query);
        }
        //Method for logging alarms.
        /// <summary>
        /// Method for logging alarms to database.
        /// Currentlyg there are seven types of alarms.
        /// 1: Emergency stop activated.
        /// 2: High speed.
        /// 3-6: Different types of zones activated, starts with zone 1.
        /// 7: Low batter.
        /// </summary>
        /// <param name="AlarmId">Id to determine which alarm is to be logged.</param>
        /// <param name="Alarmvalue"></param>
        public void LogAlarms(int AlarmId, double Alarmvalue)
        {
            string Query;
            Timestamp = DateTime.Now;
            Query = String.Concat(@"insert into Timestamp values ('",Timestamp,"')" +
                "insert into Alarms values ('", Timestamp ,"','",AlarmId,"','",Alarmvalue,"')");
            CnnSendCommand(Query);
        }
        #endregion


    }
}
