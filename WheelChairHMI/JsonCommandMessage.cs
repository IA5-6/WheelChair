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
            Prop1 = 0;
            Prop2 = 0;
            Prop3 = 0;
        }
        /// <summary>
        /// Constructor for initialising the properties
        /// </summary>
        /// <param name="prop1">The first property</param>
        /// <param name="prop2">The second property</param>
        /// <param name="prop3">the third property</param>
        public JsonCommandMessage(int prop1, int prop2, int prop3)
        {
            Prop1 = prop1;
            Prop2 = prop2;
            Prop3 = prop3;
        }

        public int Prop1 { get; set; }

        public int Prop2 { get; set; }

        public int Prop3 { get; set; }
    }
}
