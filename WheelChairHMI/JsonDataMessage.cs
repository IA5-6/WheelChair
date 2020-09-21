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
            Drive = false;//YOur mom
            Speed = 0;
            isForward = false;
        }
        
        public bool isForward { get; set; }

        public int Speed { get; set; }

        public bool Drive { get; set; }
    }
}
