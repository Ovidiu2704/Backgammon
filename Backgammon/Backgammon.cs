using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{
    public partial class Backgammon : Form
    {
        public Triunghi tri;
        public generarePiese generare;
        public aranjarepiese pp;
        public zaruri zr;
        public int juc, palbe, pnegre, sum1, sum2;
        public string zarus1, zarus2;
        public Backgammon()
        {
            InitializeComponent();
            tri = new Triunghi(this);
            generare = new generarePiese(this, tri);
            pp = new aranjarepiese(generare);
            zr = new zaruri();
            juc = 0;
            palbe = 15;
            pnegre = 15;
            sum1 = 0;
            button1.FlatAppearance.BorderSize = 0;
            generare.generare_piese();
            pp.aranjareinceput();
            tri.manevra();
            pozitie();
        }
        async public void pozitie()
        {
            while (true)
            {
                for (int j = 0; j < 26; j++)
                {
                    for (int i = 0; i < 30; i++)

                    {
                        if (generare.alb[i].Bounds.IntersectsWith(tri.triunghiuri[j].Bounds) && !generare.alb[i].ptriunghi && !generare.alb[i].miscare)
                        {
                            switch (tri.triunghiuri[j].contor)
                            {
                                case 0:
                                    {

                                        tri.triunghiuri[j].culoare = generare.alb[i].culoare;
                                        tri.triunghiuri[j].last[tri.triunghiuri[j].contor] = i;
                                        if (tri.triunghiuri[generare.alb[i].poz].contor > 0)
                                            tri.triunghiuri[generare.alb[i].poz].contor--;
                                        generare.alb[i].ptriunghi = true;
                                        generare.alb[i].poz = j;
                                        if (j < 12)
                                        {
                                            generare.alb[i].Left = tri.triunghiuri[j].Left;
                                            generare.alb[i].Top = tri.triunghiuri[j].Top + tri.triunghiuri[j].contor * 60;

                                        }
                                        else
                                        {
                                            generare.alb[i].Left = tri.triunghiuri[j].Left;
                                            generare.alb[i].Top = tri.triunghiuri[j].Top + 240 - tri.triunghiuri[j].contor * 60;

                                        }
                                        tri.triunghiuri[j].contor++;
                                    }
                                    break;
                                case 1:
                                    {

                                        if (generare.alb[i].culoare != tri.triunghiuri[j].culoare)
                                        {
                                            generare.alb[i].ptriunghi = true;
                                            tri.triunghiuri[j].culoare = generare.alb[i].culoare;
                                            if (tri.triunghiuri[generare.alb[i].poz].contor > 0)
                                                tri.triunghiuri[generare.alb[i].poz].contor--;
                                            generare.alb[i].poz = j;
                                            tri.triunghiuri[j].contor--;


                                            if (j < 12)
                                            {
                                                generare.alb[i].Left = tri.triunghiuri[j].Left;
                                                generare.alb[i].Top = tri.triunghiuri[j].Top + tri.triunghiuri[j].contor * 60;

                                            }
                                            else
                                            {
                                                generare.alb[i].Left = tri.triunghiuri[j].Left;
                                                generare.alb[i].Top = tri.triunghiuri[j].Top + 240 - tri.triunghiuri[j].contor * 60;

                                            }

                                            if (generare.alb[tri.triunghiuri[j].last[tri.triunghiuri[j].contor]].culoare)
                                            {
                                                generare.alb[tri.triunghiuri[j].last[tri.triunghiuri[j].contor]].Top = 320;
                                                generare.alb[tri.triunghiuri[j].last[tri.triunghiuri[j].contor]].Left = 465;
                                                generare.alb[tri.triunghiuri[j].last[tri.triunghiuri[j].contor]].poz = 24;
                                                tri.triunghiuri[24].last[tri.triunghiuri[j].contor] = i;
                                                tri.triunghiuri[24].contor++;
                                                tri.triunghiuri[24].culoare = true;





                                            }
                                            else
                                            {
                                                generare.alb[tri.triunghiuri[j].last[tri.triunghiuri[j].contor]].Top = 380;
                                                generare.alb[tri.triunghiuri[j].last[tri.triunghiuri[j].contor]].Left = 465;
                                                generare.alb[tri.triunghiuri[j].last[tri.triunghiuri[j].contor]].poz = 25;
                                                tri.triunghiuri[25].last[tri.triunghiuri[j].contor] = i;
                                                tri.triunghiuri[25].contor++;
                                                tri.triunghiuri[24].culoare = false;

                                            }

                                            tri.triunghiuri[j].last[tri.triunghiuri[j].contor] = i;
                                            tri.triunghiuri[j].contor++;

                                        }
                                        else
                                        {
                                            if (tri.triunghiuri[generare.alb[i].poz].contor > 0)
                                                tri.triunghiuri[generare.alb[i].poz].contor--;
                                            generare.alb[i].ptriunghi = true;
                                            generare.alb[i].poz = j;
                                            tri.triunghiuri[j].last[tri.triunghiuri[j].contor] = i;
                                            tri.triunghiuri[j].culoare = generare.alb[i].culoare;
                                            if (j < 12)
                                            {
                                                generare.alb[i].Left = tri.triunghiuri[j].Left;
                                                generare.alb[i].Top = tri.triunghiuri[j].Top + tri.triunghiuri[j].contor * 60;

                                            }
                                            else
                                            {
                                                generare.alb[i].Left = tri.triunghiuri[j].Left;
                                                generare.alb[i].Top = tri.triunghiuri[j].Top + 240 - tri.triunghiuri[j].contor * 60;

                                            }
                                            tri.triunghiuri[j].contor++;
                                        }


                                    }
                                    break;
                                default:
                                    {

                                        if (generare.alb[i].culoare == tri.triunghiuri[j].culoare)
                                        {
                                            tri.triunghiuri[j].culoare = generare.alb[i].culoare;
                                            if (tri.triunghiuri[generare.alb[i].poz].contor > 0)
                                                tri.triunghiuri[generare.alb[i].poz].contor--;
                                            tri.triunghiuri[j].last[tri.triunghiuri[j].contor] = i;

                                            generare.alb[i].ptriunghi = true;
                                            generare.alb[i].poz = j;
                                            if (j < 12)
                                            {
                                                generare.alb[i].Left = tri.triunghiuri[j].Left;
                                                generare.alb[i].Top = tri.triunghiuri[j].Top + tri.triunghiuri[j].contor * 60;

                                            }
                                            else
                                            {
                                                generare.alb[i].Left = tri.triunghiuri[j].Left;
                                                generare.alb[i].Top = tri.triunghiuri[j].Top + 240 - tri.triunghiuri[j].contor * 60;

                                            }
                                            tri.triunghiuri[j].contor++;
                                        }
                                        else
                                        {
                                            if (j < 12)
                                            {
                                                generare.alb[i].Left = tri.triunghiuri[generare.alb[i].poz].Left;
                                                generare.alb[i].Top = tri.triunghiuri[generare.alb[i].poz].Top + (tri.triunghiuri[generare.alb[i].poz].contor - 1) * 60;

                                            }
                                            else
                                            {
                                                generare.alb[i].Left = tri.triunghiuri[generare.alb[i].poz].Left;
                                                generare.alb[i].Top = tri.triunghiuri[generare.alb[i].poz].Top + 240 - (tri.triunghiuri[generare.alb[i].poz].contor - 1) * 60;

                                            }
                                        }

                                        break;
                                    }


                            }

                        }


                    }
                }


                await Task.Delay(5);

            }
        }

        async private void button1_Click(object sender, System.EventArgs e)
        {
            button1.Enabled = false;
            zr.daucuzaru66();
            juc++;
            zarus1 = (zr.zar1 + 1) + ".png";
            zarus2 = (zr.zar2 + 1) + ".png";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            await Task.Delay(100);
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.Image = System.Drawing.Image.FromFile(zarus1);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = System.Drawing.Image.FromFile(zarus2);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            for (int i = 0; i < 6; i++)
                if (tri.triunghiuri[i].culoare == true)
                    sum1 += tri.triunghiuri[i].contor;
            for (int i = 23; i > 17; i--)
                if (tri.triunghiuri[i].culoare == false)
                    sum2 += tri.triunghiuri[i].contor;
            await Task.Delay(100);
            if (juc % 2 == 1)
            {
                if (sum1 == palbe)
                {
                    if (tri.triunghiuri[zr.zar1].contor > 0)
                        if (tri.triunghiuri[zr.zar1].culoare == true)
                        {
                            tri.triunghiuri[zr.zar1].contor--;
                            generare.alb[tri.triunghiuri[zr.zar1].last[tri.triunghiuri[zr.zar1].contor]].Dispose();
                            palbe--;
                            await Task.Delay(750);
                        }
                    
                    if (tri.triunghiuri[zr.zar2].contor > 0)
                        if (tri.triunghiuri[zr.zar2].culoare == true)
                        {
                            tri.triunghiuri[zr.zar2].contor--;
                            generare.alb[tri.triunghiuri[zr.zar2].last[tri.triunghiuri[zr.zar2].contor]].Dispose();
                            palbe--;
                            await Task.Delay(750);
                        }
                    
                    if (zr.zar1 == zr.zar2)
                    {
                        if (tri.triunghiuri[zr.zar1].culoare == true)
                            if (tri.triunghiuri[zr.zar1].contor > 0)
                            {
                                tri.triunghiuri[zr.zar1].contor--;
                                generare.alb[tri.triunghiuri[zr.zar1].last[tri.triunghiuri[zr.zar1].contor]].Dispose();
                                palbe--;
                                await Task.Delay(750);
                            }
                        
                        if (tri.triunghiuri[zr.zar1].culoare == true)
                            if (tri.triunghiuri[zr.zar1].contor > 0)
                            {
                                tri.triunghiuri[zr.zar1].contor--;
                                generare.alb[tri.triunghiuri[zr.zar1].last[tri.triunghiuri[zr.zar1].contor]].Dispose();
                                palbe--;
                                await Task.Delay(750);
                            }
                    }
                    

                }


            }
            else

                if (sum2 == pnegre)
            {
                if (tri.triunghiuri[23 - zr.zar1].culoare == false)
                    if (tri.triunghiuri[23 - zr.zar1].contor > 0)
                    {
                        tri.triunghiuri[23 - zr.zar1].contor--;
                        generare.alb[tri.triunghiuri[23 - zr.zar1].last[tri.triunghiuri[23 - zr.zar1].contor]].Dispose();
                        pnegre--;
                        await Task.Delay(750);
                    }
                
                if (tri.triunghiuri[23 - zr.zar2].culoare == false)
                    if (tri.triunghiuri[23 - zr.zar2].contor > 0)
                    {
                        tri.triunghiuri[23 - zr.zar2].contor--;
                        generare.alb[tri.triunghiuri[23 - zr.zar2].last[tri.triunghiuri[23 - zr.zar2].contor]].Dispose();
                        pnegre--;
                        await Task.Delay(750);
                    }
                
                if (zr.zar1 == zr.zar2)
                {
                    if (tri.triunghiuri[23 - zr.zar1].culoare == false)
                        if (tri.triunghiuri[23 - zr.zar1].contor > 0)
                        {
                            tri.triunghiuri[23 - zr.zar1].contor--;
                            generare.alb[tri.triunghiuri[23 - zr.zar1].last[tri.triunghiuri[23 - zr.zar1].contor]].Dispose();
                            pnegre--;
                            await Task.Delay(750);
                        }
                    
                    if (tri.triunghiuri[23 - zr.zar1].culoare == false)
                        if (tri.triunghiuri[23 - zr.zar1].contor > 0)
                        {
                            tri.triunghiuri[23 - zr.zar1].contor--;
                            generare.alb[tri.triunghiuri[23 - zr.zar1].last[tri.triunghiuri[23 - zr.zar1].contor]].Dispose();
                            pnegre--;
                            await Task.Delay(750);
                        }
                    
                }
            }


            sum1 = 0;
            sum2 = 0;
            DialogResult rezultat;
            if (palbe == 0)
            {
                
                rezultat=MessageBox.Show("Playerul cu piesele albe a castigat."," " ,MessageBoxButtons.OK);
                if (rezultat == System.Windows.Forms.DialogResult.OK)
                    this.Close();
            }
            if (pnegre == 0)
            {

                rezultat = MessageBox.Show("Playerul cu piesele negre a castigat.", " ", MessageBoxButtons.OK);
                if (rezultat == System.Windows.Forms.DialogResult.OK)
                    this.Close();
            }

            button1.Enabled = true;
        }
    }
}

