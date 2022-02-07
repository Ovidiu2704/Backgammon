using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{
    public class piese : PictureBox
    {
        Point locatie;
        public bool culoare;
        public bool ptriunghi;
        public bool miscare;
        public int poz;
        Triunghi triunghi;
        public piese(Triunghi triun)
        {
            Top = 350;
            Left = 10;
            poz = 24;
            ptriunghi = false;
            miscare = false;
            triunghi = triun;
            BackColor = Color.Transparent;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            locatie = e.Location;
            miscare = true;
            base.OnMouseDown(e);
            ptriunghi = false;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - locatie.X;
                this.Top += e.Y - locatie.Y;
                this.BringToFront();
            }
            base.OnMouseMove(e);

        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            locatie = e.Location;
            miscare = false;
            base.OnMouseUp(e);
        }

    }
}
