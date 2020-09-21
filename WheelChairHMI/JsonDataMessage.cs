using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelChairHMI
{
    class JsonDataMessage
    {
        public JsonDataMessage()
        {
            
        }
        
        public bool EmergencyStop { get; set; }

        public int Speed { get; set; }

        public bool Zone1Tripped { get; set; }

        public bool Zone2Tripped { get; set; }

        public bool Zone3Tripped { get; set; }

        public bool Zone4Tripped { get; set; }

        public int BatteryLevel { get; set; }
    }
}
