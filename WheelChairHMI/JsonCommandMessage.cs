using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelChairHMI
{
    /// <summary>
    /// The class with the structure for sending commands to the wheelchair 
    /// </summary>
    class JsonCommandMessage
    {
        /// <summary>
        /// Sets all the properties to 0 or false
        /// </summary>
        public JsonCommandMessage()
        {
            Speed = 0;
            Drive = false;
            Left = false;
            Right = false;
        }
        /// <summary>
        /// Constructor for initialising the properties
        /// </summary>
        /// <param name="speed">The speed value to the wheelchair</param>
        /// <param name="drive">The flag to command the wheelchair to drive</param>
        /// <param name="left">The flag to command the wheelchair to go left</param>
        /// <param name="right">The flag to command the wheelchair to go left</param>
        public JsonCommandMessage(int speed, bool drive, bool left,bool right)
        {
            Speed = speed;
            Drive = drive;
            Left = left;
            Right = right;
        }

        public int Speed { get; set; }

        public bool Drive { get; set; }

        public bool Left { get; set; }

        public bool Right { get; set; }

        public bool Auto { get; set; }
    }
}
