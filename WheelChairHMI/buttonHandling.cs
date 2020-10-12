using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelChairHMI
{
    class ButtonHandling
    {
        private readonly Communication Com;
        

        public ButtonHandling(Communication com)
        {
            Com = com;
           
        }
        public ButtonHandling()
        {

        }

        public void ProcessBtnClick(Keys key)
        {
            
            switch (key)
            {
                case Keys.Up:
                    Com.DriveForward();
                    break;
                case Keys.Left:
                    Com.TurnLeft();
                    break;
                case Keys.Right:
                    Com.TurnRight();
                    break;
                case Keys.Down:
                    Com.DriveBack();
                    break;
                case Keys.A:
                    Com.SelfDriving();
                    break;
                default:
                    break;
            }
            Com.SendObjViaSerial();
        }
    }
}
