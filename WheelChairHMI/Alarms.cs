using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WheelChairHMI
{
    class Alarm : Form1
    {
        List<bool> alarmCheck = new  List<bool>();
        List<string> alarm = new List<string>();
       
       
        List<string> alarmListValue = new List<string>(); //Should be 
        List<string> alarmListName = new List<string>(); //Should be 
        public Alarm()//Alarm constructor
        {
           
            AlarmStample();
      
        }
        private void alarmBoolList()
        {
            for (int i = 0; i < 7; i++)
            {
                alarmCheck.Add(false);
            }
          /*  bool emergencyStop = false;
            bool speed = false;
            bool zoneOneTripped = false;
            bool zoneTwoTripped = false;
            bool zoneThreeTripped = false;
            bool zoneFourTripped = false;
            bool lowBattery = false;*/
        }

        private void AlarmStample()
        {
            
            DateTime alarmTime = DateTime.Now;
            int iNumber = 0;
            for (int i = 0; i < alarmCheck.Count; i++)
            {
                if (alarmCheck[iNumber]==true)
                {
                    alarm.Add(alarmTime.ToString());
                    alarm.Add(alarmListName[iNumber]);
                    alarm.Add(alarmListValue[iNumber]);
                }
                iNumber ++;
            }
            
           
        }

        private void AlarmCheck (JsonDataMessage arduinoValues)//Must chech how to inport json !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            foreach (Propertyinfo prop in Arduinovalues)
            {
                alarmListValue.Add(prop.GetValue().ToString());
                alarmListName.Add(prop.Name);
            }
            if (alarmListValue[0] != "False")
            {
                alarmBoolList[0]=(true);
            }
            else if(Convert.ToInt32(alarmListValue[1])>10)//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Must change value to more spesific
            {
                speed = true;
            }
            else if(alarmListValue[2]!= "False")
            {
                zoneOneTripped = true;
            }
            else if (alarmListValue[3] != "False")
            {
                zoneTwoTripped = true;
            }
            else if (alarmListValue[4] != "False")
            {
                zoneThreeTripped = true;
            }
            else if (alarmListValue[5] != "False")
            {
                zoneFourTripped = true;
            }
            else if (Convert.ToInt32(alarmListValue[6] )< 50)//!!!!!!!!!!!!!!!!!!!!!!!!Unsure on this parameter of low battery.
            {
                lowBattery = true;
            }

        }
        

    }
}
