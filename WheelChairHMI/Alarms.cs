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
        public event EventHandler Emergency;   // Event for Emergency stop
        public event EventHandler Speed;       // Event for high Speed
        public event EventHandler ZoneActive1; //Event for active Zone1
        public event EventHandler ZoneActive2; //Event for active Zone2
        public event EventHandler ZoneActive3; //Event for active Zone3
        public event EventHandler ZoneActive4; //Event for active Zone4
        public event EventHandler Battery;    //Event for low battery
        bool[] alarmCheck;
       
        List<string> alarmListValue; //Creating list for values
        List<string> alarmListName; //Creating list for names

        public Alarm()//Alarm constructor
        {
            alarmCheck= new bool[7]; //Bool with all alarmvariables
            alarmListValue = new List<string>(); //Should be 
            alarmListName = new List<string>(); //Should be 
        }
        /// <summary>
        /// Sets all the elements of the alarmcheck array to false.
        /// </summary>
        public void alarmBoolList() //Sets all boolindex to false
        {
            for (int i = 0; i < alarmCheck.Length; i++)
            {
                alarmCheck[i]=false;
            }
       
        }


        public void AlarmCheck (JsonDataMessage arduinoValues)//Checking the alarmvalues and makes event if true
        {
            foreach (PropertyInfo prop in arduinoValues.GetType().GetProperties()) //Getting values from arudino
            {
                alarmListValue.Add(prop.GetValue(arduinoValues).ToString()); //adding values to list of the last updated value from arduino
                alarmListName.Add(prop.Name); //Adding names to the list with alarmnames
            }
            if (alarmCheck[0]==false) //Checking if the emergencyStop bool is active
                {
                    if (alarmListValue[0]=="true") //Checking the value on emergencyStop
                    {
                        alarmCheck[0] = true;
                        Emergency(this, new EventArgs()); //Making event for Emergency
                    }
            }
            if(alarmCheck[1]==false) //Checking if the speed bool is false
            {
                if (Convert.ToInt64(alarmListValue[1]) > 10)//If the speed is faster then...MUST CHANGE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    alarmCheck[1] = true;
                    Speed(this, new EventArgs()); //Making event for high speed
                }
            }
            if (alarmCheck[2]==false)//Checking if the Zone1 bool is false
            {
                if (alarmListValue[2] != "False")//Checking if the Zone1 value is false
                {
                    alarmCheck[2] = (true);
                    ZoneActive1(this, new EventArgs()); //Making event for Zone1 activated
                }
            }
            if (alarmCheck[3] == false)//Checking if the Zone2 bool is false
            {
                if (alarmListValue[3] != "False")//Checking if the Zone2 value is false
                {
                    alarmCheck[3] = (true);
                    ZoneActive2(this, new EventArgs()); //Making event for Zone2 activated
                }
            }
            if (alarmCheck[4] == false)//Checking if the Zone3 bool is false
            {
                if (alarmListValue[4] != "False")//Checking if the Zone3 value is false
                {
                    alarmCheck[4] = (true);
                    ZoneActive3(this, new EventArgs()); //Making event for Zone3 activated
                }
            }
            if (alarmCheck[5] == false)//Checking if the Zone4 bool is false
            {
                if (alarmListValue[5] != "False")//Checking if the Zone4 value is false
                {
                    alarmCheck[5] = (true);
                    ZoneActive4(this, new EventArgs()); //Making event for Zone4 activated
                }
            }
            if (alarmCheck[6] == false)//Checking if the battery low bool is false
            {
                if (Convert.ToInt64(alarmListValue[5])< 100)//MUST CHANGE VALUE TO MORE SPESIFIC!!!!!!!!!!!!!!
                {
                    alarmCheck[5] = (true);
                    Battery(this, new EventArgs()); //Making event for low battery
                }
            }

        }
       
        
       

    }
}
