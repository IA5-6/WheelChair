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
            Drive = true;
            Speed = 0;
            isForward = true;
        }
        public JsonMessage(bool drive, int speed, bool isForward)
        {
            Drive = drive;
            Speed = speed;
            this.isForward = isForward;
        }
        public bool isForward { get; set; }

        public int Speed { get; set; }

        public bool Drive { get; set; }
    }
}
