using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelChairHMI
{
    class buttonHandling
    {
        private Communication Com;
        
        public buttonHandling(Communication com)
        {
            Com = com;
        }
        public buttonHandling()
        {

        }

        public void processBtnClick(Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    MessageBox.Show("Key up");
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
