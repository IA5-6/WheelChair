using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelChairHMI
{
    class JsonMessage
    {
        public JsonMessage()
        {
            Drive = false;
            Speed = 0;
            isForward = true;
        }
        
        public bool isForward { get; set; }

        public int Speed { get; set; }

        public bool Drive { get; set; }
    }
}
