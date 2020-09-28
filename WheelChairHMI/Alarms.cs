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
        public event EventHandler Emergency;
        public event EventHandler Speed;
        public event EventHandler ZoneActive1;
        public event EventHandler ZoneActive2;
        public event EventHandler ZoneActive3;
        public event EventHandler ZoneActive4;
        public event EventHandler Battery;
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
       
        }


        public void AlarmCheck (JsonDataMessage arduinoValues)//Must chech how to inport json !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            foreach (PropertyInfo prop in arduinoValues.GetType().GetProperties())
            {
                alarmListValue.Add(prop.GetValue(arduinoValues).ToString());
                alarmListName.Add(prop.Name);
            }
            
                if (alarmCheck[0]==false)
                {
                    if (alarmListValue[0]=="true")
                    {
                        alarmCheck[0] = true;
                        Emergency(this, new EventArgs());
                    }

                }
                else if(alarmCheck[1]==false) //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Must change value to more spesific
                {
                if (Convert.ToInt64(alarmListValue[]) > 10)//If the speed is faster then...
                {

                    alarmCheck[1] = true;
                    Speed(this, new EventArgs());
                }
                }
                else if (alarmCheck[2]==false)
                {
                if (alarmListValue[2] != "False")
                {
                    alarmCheck[2] = (true);
                    ZoneActive1(this, new EventArgs());
                }
                }
            else if (alarmCheck[3] == false)
            {
                if (alarmListValue[3] != "False")
                {
                    alarmCheck[3] = (true);
                    ZoneActive2(this, new EventArgs());
                }
            }
            else if (alarmCheck[4] == false)
            {
                if (alarmListValue[4] != "False")
                {
                    alarmCheck[4] = (true);
                    ZoneActive3(this, new EventArgs());
                }
            }
            else if (alarmCheck[5] == false)
            {
                if (alarmListValue[5] != "False")
                {
                    alarmCheck[5] = (true);
                    ZoneActive4(this, new EventArgs());
                }
            }
            else if (alarmCheck[6] == false)
            {
                if (Convert.ToInt64(alarmListValue[5])< 100)//MUST CHANGE VALUE TO MORE SPESIFIC!!!!!!!!!!!!!!
                {
                    alarmCheck[5] = (true);
                    Battery(this, new EventArgs());
                }
            }

        }
        //!!!!!!!
        
        public List<string> AlarmCollection { get { return alarmCollection; } }

    }
}
