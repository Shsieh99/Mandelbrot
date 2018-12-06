using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    public class Realnumbers
    {


        public static double cx;
        public static double cy;



        public double a; //realnumber
        public double b; //realnumber

        public Realnumbers(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Square()
        {
            double temp = (a * a) - (b * b) + cx; //temporarily value
            b = (2.0 * a * b) + cy;
            a = temp;
        }

        public double Magnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void Add(Realnumbers c)
        {
            a += c.a;
            b += c.b;
        }
        

    }
}
