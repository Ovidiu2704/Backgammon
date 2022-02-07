using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backgammon
{
    public class aranjarepiese
    {
        generarePiese pp1;
        public aranjarepiese(generarePiese pp)
        {
            pp1 = pp;

        }
        public void aranjareinceput()
        {
            for (int i = 0; i < 5; i++)
            {
                pp1.alb[i].Top = 0;
                pp1.alb[i].Left = 415;
            }
            for (int i = 5; i < 8; i++)
            {
                pp1.alb[i].Top = 0;
                pp1.alb[i].Left = 595;
            }
            for (int i = 8; i < 13; i++)
            {
                pp1.alb[i].Top = 500;
                pp1.alb[i].Left = 920;
            }
            for (int i = 13; i < 15; i++)
            {
                pp1.alb[i].Top = 500;
                pp1.alb[i].Left = 10;
            }
            for (int i = 15; i < 17; i++)
            {
                pp1.alb[i].Top = 0;
                pp1.alb[i].Left = 10;
            }
            for (int i = 17; i < 22; i++)
            {
                pp1.alb[i].Top = 0;
                pp1.alb[i].Left = 920;
            }
            for (int i = 22; i < 25; i++)
            {
                pp1.alb[i].Top = 500;
                pp1.alb[i].Left = 595;
            }
            for (int i = 25; i < 30; i++)
            {
                pp1.alb[i].Top = 500;
                pp1.alb[i].Left = 415;
            }
        }
    }

}
