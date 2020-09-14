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
        //Method for logging distance
        /// <summary>
        /// Logs the distance driven to database.
        /// </summary>
        /// <param name="distance">Distance is in meters</param>
        public void LogDistance(double distance)
        {
            string Query,data;
            data = "Distance";
            Timestamp = DateTime.Now;
            Query = String.Concat(@"INSERT INTO Timestamp VALUES ('", Timestamp, "','", data, "')"
                + "INSERT INTO Data Values('", Timestamp, "','", 2, "','",distance,"')");
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
        #endregion


    }
}
