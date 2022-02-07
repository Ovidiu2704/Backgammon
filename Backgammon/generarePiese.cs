using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{

    public class generarePiese
    {
        Backgammon form2;
        Triunghi tttt;
        public piese[] alb = new piese[30];
        public void generare_piese()
        {
            for (int i = 0; i < 30; i++)
            {

                alb[i] = new piese(tttt);
                if (i < 15)
                {
                    alb[i].Image = System.Drawing.Image.FromFile("White.jpg");
                    alb[i].culoare = true;
                }
                else
                {
                    alb[i].Image = System.Drawing.Image.FromFile("Black.jpg");
                    alb[i].culoare = false;
                }

                alb[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                alb[i].Size = new Size(60, 60);
                form2.Controls.Add(alb[i]);
            }
        }
        public generarePiese(Backgammon f2, Triunghi triunghiuriri)
        {
            form2 = f2;
            tttt = triunghiuriri;
        }

    }
}
