using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{
    public class coliziuni : PictureBox
    {
        public int contor;
        public int[] last = new int[100];
        public bool culoare;

        public coliziuni()
        {
            contor = 0;
            Height = 300;
            Width = 30;
            Visible = false;


        }

    }
}
