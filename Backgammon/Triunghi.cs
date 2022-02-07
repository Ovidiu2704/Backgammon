using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{
    public class Triunghi
    {
        public coliziuni[] triunghiuri = new coliziuni[27];
        Backgammon form2;
        public void manevra()
        {
            for (int i = 0; i < 6; i++)
            {
                triunghiuri[i] = new coliziuni();
                triunghiuri[i + 6] = new coliziuni();
                triunghiuri[i].Left = i * 81 + 8;
                triunghiuri[i].Top = 0;
                triunghiuri[i + 6].Left = i * 81 + 512;
                triunghiuri[i + 6].Top = 0;
                form2.Controls.Add(triunghiuri[i]);
                form2.Controls.Add(triunghiuri[i + 6]);

            }
            for (int i = 12; i < 18; i++)
            {
                triunghiuri[i] = new coliziuni();
                triunghiuri[i + 6] = new coliziuni();
                triunghiuri[i].Left = 917 - (i - 12) * 81;
                triunghiuri[i].Top = 463;
                triunghiuri[i + 6].Left = 413 - (i - 12) * 81;
                triunghiuri[i + 6].Top = 463;
                form2.Controls.Add(triunghiuri[i]);
                form2.Controls.Add(triunghiuri[i + 6]);
            }
            triunghiuri[24] = new coliziuni();
            triunghiuri[25] = new coliziuni();
            triunghiuri[26] = new coliziuni();


        }
        public Triunghi(Backgammon f2)
        {
            form2 = f2;

        }
    }
}
