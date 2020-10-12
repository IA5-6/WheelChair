using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelChairHMI
{
    class DataHandling : DB_Handling
    {
        public DataHandling(bool logData,string config):base(config)
        {
            LogDataBit = logData;
        }

        /// <summary>
        /// Event which is used to UpdateData
        /// </summary>
        public event EventHandler UpdateData;
        /// <summary>
        /// If true we can log data, if false we cant.
        /// </summary>
        public bool LogDataBit { get; set; }
        /// <summary>
        /// Method for invoking the DataLog event.
        /// </summary>
        public void SendData(JsonDataMessage json)
        {
            if (LogDataBit)
            {
                LogData(1, json.BatteryLevel);
                LogData(3, json.Speed);
                LogDataBit = false;
                RunUpdateData();
            }
        }
        public void RunUpdateData()
        {
            UpdateData(this, new EventArgs());
        }

    }
}
