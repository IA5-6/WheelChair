using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace WheelChairHMI
{
    class Alarm
    {
        bool[] alarmCheck;
        List<string> alarmCollection;


        List<string> alarmListValue;
        List<string> alarmListName;
       
        public Alarm()//Alarm constructor
        {
            alarmCheck= new bool[7];
            alarmCollection= new List<string>();
            alarmListValue = new List<string>(); //Should be 
            alarmListName = new List<string>(); //Should be 
        }

        private void alarmBoolList()
        {
            for (int i = 0; i < alarmCheck.Length; i++)
            {
                alarmCheck[i]=false;
            }
          /*  bool emergencyStop = false;
            bool speed = false;
            bool zoneOneTripped = false;
            bool zoneTwoTripped = false;
            bool zoneThreeTripped = false;
            bool zoneFourTripped = false;
            bool lowBattery = false;*/
        }


        public void AlarmCheck (JsonDataMessage arduinoValues)//Must chech how to inport json !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            foreach (PropertyInfo prop in arduinoValues.GetType().GetProperties())
            {
                alarmListValue.Add(prop.GetValue(arduinoValues).ToString());
                alarmListName.Add(prop.Name);
            }
            if (alarmListValue[0] != "False")
            {
                alarmCheck[0]=true;
            }
            else if(Convert.ToInt32(alarmListValue[1])>10)//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Must change value to more spesific
            {
                alarmCheck[1] = (true);
            }
            else if(alarmListValue[2]!= "False")
            {
                alarmCheck[2] = (true);
            }
            else if (alarmListValue[3] != "False")
            {
                alarmCheck[3] = (true);
            }
            else if (alarmListValue[4] != "False")
            {
                alarmCheck[4] = (true);
            }
            else if (alarmListValue[5] != "False")
            {
                alarmCheck[5] = (true);
            }
            else if (Convert.ToInt32(alarmListValue[6] )< 50)//!!!!!!!!!!!!!!!!!!!!!!!!Unsure on this parameter of low battery.
            {
                alarmCheck[6] = (true);
            }
            AlarmStample();
        }
        private void AlarmStample() //Alarmclass that stample the alarm and add the values to a new list 
        {
            
            DateTime alarmTime = DateTime.Now;
            
            for (int i = 0; i < alarmCheck.Length; i++)
            {
                if (alarmCheck[i]==true)
                {
                    alarmCollection.Add(alarmTime.ToString());
                    alarmCollection.Add(alarmListName[i]);
                    alarmCollection.Add(alarmListValue[i]);
                }
               
            }
            
           
        }
        public List<string> AlarmCollection { get { return alarmCollection; } }

    }
}
