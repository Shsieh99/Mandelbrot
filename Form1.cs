using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int x=0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    double p = 2;
                    double q = 4;
                    double a = (double)(x - (pictureBox1.Width / p)) / (double)(pictureBox1.Width / q);
                    double b = (double)(y - (pictureBox1.Height / p)) / (double)(pictureBox1.Height / q);
                    Realnumbers c = new Realnumbers(a, b);
                    Realnumbers z = new Realnumbers(0, 0);

                    double cx = 0;
                    double cy = 0;
                    double tempa = 0;
                    int it = 0;
                    int itmax = 1000;
                    do
                    {
                        it++;
                        z.Square();
                        z.Add(c);
                        if (z.Magnitude() > 2.0) break;
                    }

                    while (a * a - b * b <= 4 && it < itmax);
                    {
                        it++;
                        tempa = a;
                        a = (a * a) - (b * b) + cx;
                        b = (2 * a * b) + cy;
                    }
                    if (it != itmax)
                        bm.SetPixel(x, y, Color.FromArgb
                            (
                             (int)Math.Sin (it) * 356, //Change color as I want 
                             it * it % 125,            //Change color as I want        
                             (int)Math.Log (it) % 203  //Change color as I want 
                            )
                             );
                    else
                        bm.SetPixel(x, y, Color.Black);


                }
            }
            pictureBox1.Image = bm;



        }

        

        public void MiddenX_TextChanged(object sender, EventArgs e)
        {
            double middenX = double.Parse(MiddenX.Text);
            middenX = Realnumbers.cx;
        }

        public void MiddenY_TextChanged(object sender, EventArgs e)
        {
            double middenY = double.Parse(MiddenY.Text);
            middenY = Realnumbers.cy;
        }

        private void Schaal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Max_TextChanged(object sender, EventArgs e)
        {
            int iteraties = int.Parse(Iteraties.Text);
            
        }
    }
}
