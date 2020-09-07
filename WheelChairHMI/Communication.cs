using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WheelChairHMI
{
    class Communication
    {
        private string ClassToJson(JsonMessage msg)
        {
            string json = JsonConvert.SerializeObject(msg);
            return json;
        }
        public void sendObjViaSerial(JsonMessage msg)
        {

        }
    }
}
