using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO.Ports;

namespace WheelChairHMI
{
    class Communication
    {
        SerialPort port;
        public Communication()
        {
            port = new SerialPort("COM19", 115200,Parity.None,8,StopBits.One);
        }
        public string ClassToJson(JsonMessage msg)
        {
            string json = JsonConvert.SerializeObject(msg);
            return json;
        }
        public void sendObjViaSerial(JsonMessage msg)
        {
            string temp = ClassToJson(msg);
            port.Open();
            port.Write(temp);
            port.Close();
        }
    }
}
