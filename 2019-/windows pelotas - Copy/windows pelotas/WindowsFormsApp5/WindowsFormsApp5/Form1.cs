using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<Pelota> lp;

        public Form1()
        {
            InitializeComponent();
            lp = new List<Pelota>();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green);
            Pen pen2 = new Pen(Color.Blue);
            Pen pen3 = new Pen(Color.Red);

            foreach (Pelota p in lp)
            {
                if(p.color == 0)
                {
                    e.Graphics.DrawEllipse(pen, p.x, p.y, 20, 20);
                }else if (p.color == 1)
                {
                    e.Graphics.DrawEllipse(pen2, p.x, p.y, 20, 20);
                }
                else if (p.color == 2)
                {
                    e.Graphics.DrawEllipse(pen3, p.x, p.y, 20, 20);
                }


            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 8);
            int randomNumber2 = random.Next(0, 3);
            Pelota p = new Pelota();
            p.direccion = randomNumber;
            p.x = e.X;
            p.y = e.Y;
            p.color = randomNumber2;
            lp.Add(p);
            Invalidate();

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Pelota> lpAux = new List<Pelota>();
            List<Pelota> lpAux2 = new List<Pelota>();
            Random random = new Random();

            foreach (Pelota p1 in lp){
                foreach(Pelota p2 in lp)
                {
                    if (p1 != p2)
                    {
                        if(p1.x + 20 >= p2.x && p1.x + 20 < p2.x + 20)
                        {
                            if((p1.y < p2.y && p2.y < p1.y + 20) || (p2.y + 20 < p1.y + 20 && p2.y + 20 > p1.y))
                            {


                                //if (p1.direccion == 1) p1.direccion = 0;
                                //else p1.direccion = 1;

                                //if (p2.direccion == 1) p2.direccion = 0;
                                //else p2.direccion = 1;

                                //if (p1.direccion == 2) p1.direccion = 3;
                                //else p1.direccion = 2;

                                //if (p2.direccion == 3) p2.direccion = 2;
                                //else p2.direccion = 3;

                                //if (p1.direccion == 4) p1.direccion = 5;
                                //else p1.direccion = 4;

                                //if (p2.direccion == 5) p2.direccion = 4;
                                //else p2.direccion = 5;

                                //if (p1.direccion == 6) p1.direccion = 7;
                                //else p1.direccion = 6;

                                //if (p2.direccion == 7) p2.direccion = 6;
                                //else p2.direccion = 7;
                                //if (p1.direccion == 1) p1.direccion = 0;
                                //else p1.direccion = 1;

                                //if (p2.direccion == 1) p2.direccion = 0;
                                //else p2.direccion = 1;

                                //if (p1.direccion == 3) p1.direccion = 2;
                                //else p1.direccion = 3;

                                //if (p2.direccion == 3) p2.direccion = 2;
                                //else p2.direccion = 3;

                                //if (p1.direccion == 5) p1.direccion = 4;
                                //else p1.direccion = 5;

                                //if (p2.direccion == 5) p2.direccion = 4;
                                //else p2.direccion = 5;

                                //if (p1.direccion == 7) p1.direccion = 6;
                                //else p1.direccion = 7;

                                //if (p2.direccion == 7) p2.direccion = 6;
                                //else p2.direccion = 7;
                              /*  if (p1.color == 2)
                                {
                                    if (p1.direccion == 0)
                                        p2.direccion = 1;
                                    if (p1.direccion == 1)
                                        p2.direccion = 0;
                                    if (p1.direccion == 2)
                                        p2.direccion = 3;
                                    if (p1.direccion == 3)
                                        p2.direccion = 2;
                                    if (p1.direccion == 4)
                                        p2.direccion = 5;
                                    if (p1.direccion == 5)
                                        p2.direccion = 4;
                                    if (p1.direccion == 6)
                                        p2.direccion = 7;
                                    if (p1.direccion == 7)
                                        p2.direccion = 6;
                                }*/
                                /*if (p2.color == 2)
                                {
                                    if (p2.direccion == 0)
                                        p1.direccion = 1;
                                    if (p2.direccion == 1)
                                        p1.direccion = 0;
                                    if (p2.direccion == 2)
                                        p1.direccion = 3;
                                    if (p2.direccion == 3)
                                        p1.direccion = 2;
                                    if (p2.direccion == 4)
                                        p1.direccion = 5;
                                    if (p2.direccion == 5)
                                        p1.direccion = 4;
                                    if (p2.direccion == 6)
                                        p1.direccion = 7;
                                    if (p2.direccion == 7)
                                        p1.direccion = 6;
                                }*/
                                if (p1.color == 0 && p2.color !=0)
                                {
                                    lpAux.Add(p2);
                                    continue;
                                }
                                if (p2.color == 0 && p1.color != 0)
                                {
                                    lpAux.Add(p1);
                                    continue;
                                }
                                if (p1.color == 1 )
                                {
                                    lpAux2.Add(p2);
                                }
                                if (p2.color == 1)
                                {
                                    lpAux2.Add(p1);
                                }
                                
                            }
                        }
                    }
                }
            }
            foreach (Pelota p1 in lpAux2)
            {
                //int randomNumber = random.Next(0, 8);
                int contrario = 0;
                if (p1.direccion == 0)
                    contrario = 1;
                if (p1.direccion == 1)
                    contrario = 0;
                if (p1.direccion == 2)
                    contrario = 3;
                if (p1.direccion == 3)
                    contrario = 2;
                if (p1.direccion == 4)
                    contrario = 5;
                if (p1.direccion == 5)
                    contrario = 4;
                if (p1.direccion == 6)
                    contrario = 7;
                if (p1.direccion == 7)
                    contrario = 6;
                Pelota p = new Pelota();
                p.direccion = contrario;
                p.x = p1.x + 20;
                p.y = p1.y + 20;
                p.color = p1.color;
                lp.Add(p);
                break;
            }
            foreach (Pelota p2 in lpAux2)
            {
                int contrario = 0;
                if (p2.direccion == 0)
                    contrario = 1;
                if (p2.direccion == 1)
                    contrario = 0;
                if (p2.direccion == 2)
                    contrario = 3;
                if (p2.direccion == 3)
                    contrario = 2;
                if (p2.direccion == 4)
                    contrario = 5;
                if (p2.direccion == 5)
                    contrario = 4;
                if (p2.direccion == 6)
                    contrario = 7;
                if (p2.direccion == 7)
                    contrario = 6;
                Pelota p = new Pelota();
                p.direccion = contrario;
                p.x = p2.x + 20;
                p.y = p2.y + 20;
                p.color = p2.color;
                lp.Add(p);
                break;
            }
            foreach (Pelota p2 in lpAux)
            {
                lp.Remove(p2);
            }
            foreach (Pelota p1 in lpAux)
            {
                lp.Remove(p1);
            }

            foreach (Pelota p in lp)
            {
                if(p.direccion == 0)
                {
                    if(p.x >= this.Width - 40)
                    {
                        p.direccion = 1;
                    }
                    else
                    {
                        p.x += 5;
                    }
                    
                }else if(p.direccion == 1)
                {
                    if (p.x <= 0)
                    {
                        p.direccion = 0;
                    }
                    else
                    {
                        p.x -= 5;
                    }
                }else if (p.direccion == 2)
                {
                    if (p.y >= this.Height - 40)
                    {
                        p.direccion = 3;
                    }
                    else
                    {
                        p.y += 5;
                    }

                }else if (p.direccion == 3)
                {
                    if (p.y <= 0)
                    {
                        p.direccion = 2;
                    }
                    else
                    {
                        p.y -= 5;
                    }
                }else if (p.direccion == 4)
                {
                    if (p.x <= 0)
                    {
                        p.direccion = 6;
                    }else if (p.y >= this.Height - 40 )
                    {
                        p.direccion = 7;
                    }else
                    {
                        p.y += 5;
                        p.x -= 5;
                    }

                }else if (p.direccion == 5)
                {
                    if (p.x >= this.Width - 40)
                    {
                        p.direccion = 7;
                    }
                    else if(p.y <= 0 )
                    {
                        p.direccion = 6;
                    }else
                    {
                        p.x += 5;
                        p.y -= 5;
                    }
                }else if (p.direccion == 6)
                {
                    if (p.x >= this.Width - 40)
                    {
                        p.direccion = 4;
                    }else if(p.y >= this.Height - 40 )
                    {
                        p.direccion = 5;
                    }else
                    {
                        p.y += 5;
                        p.x += 5;
                    }

                } else if (p.direccion == 7)
                {
                    if (p.y <= 0 )
                    {
                        p.direccion = 4;
                    }else if (p.x <= 0)
                    {
                        p.direccion = 5;
                    }
                    else
                    {
                        p.x -= 5;
                        p.y -= 5;
                    }
                }

            }
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
