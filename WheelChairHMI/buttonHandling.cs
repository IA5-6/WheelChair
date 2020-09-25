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
        private readonly JsonCommandMessage cmd;

        public ButtonHandling(Communication com)
        {
            Com = com;
            cmd = new JsonCommandMessage();
        }
        public ButtonHandling()
        {

        }

        public void ProcessBtnClick(Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    cmd.Prop1 = 1;
                    Com.SendObjViaSerial(cmd);
                    break;
                case Keys.Left:
                    MessageBox.Show("Key left");
                    break;
                case Keys.Right:
                    MessageBox.Show("Key right");
                    break;
                case Keys.Down:
                    MessageBox.Show("Key down");
                    break;
                default:
                    break;
            }
        }
    }
}
