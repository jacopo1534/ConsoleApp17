using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp17;

namespace ConsoleApp17
{
    internal class vector 
    {
        public vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
        
        public static vector Parse(string s)
        {
            string[] xy = s.Split(';');
            return new vector(double.Parse(xy[0]), double.Parse(xy[1]));
        }
        public static bool Parse(string s, out vector va )
        {
            try
            {
                va = vector.Parse(s);
                return true; 
            }
            catch
            {
                va = null;
                return false;
            }
        }
        public override string ToString()
        {
            return $"{X};{Y}";
        }
        public static vector operator + (vector a, vector b)
        {
            return new vector(a.X + b.X, a.Y+b.Y) ;
        }
        public static vector operator + (vector  a)
        {
            return new vector    (+a.X, +a.Y) ;
        }
        public static vector operator - (vector a, vector b)
        {
            return new vector(a.X-b.X, a.Y-b.Y) ;
        }
        public static vector operator -(vector a)
        {
            return new vector(-a.X, -a.Y);
        }
        public static vector operator * (vector a, vector b)
        {
            return new vector (a.X*b.X,a.Y*b.Y) ;
        }
        public static vector operator * (vector a, int b )
        {
            return new vector(a.X * b, a.Y * b);
        }
        public static vector operator *(int b, vector a)
        {
            return new vector(b*a.X,b*a.Y);
        }
        public static vector operator / (vector a,int b)
        {
            return new vector(a.X/b,a.Y/b);
        }
        public double Modulo(vector va)
        {
            double risultato = Math.Sqrt(Math.Pow(va.X, 2) + Math.Pow(va.Y, 2));
            return risultato;
        }
        public static bool operator !=(vector a, vector b)
        {
            if (!(a.X == b.X && a.Y == b.Y))
            {
                return true;
            }
            else
                return false;
        }


        public static bool operator == (vector  v1,vector v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y)
            {
                return true;
            }
            else { return false; }
        }

    }

}




    internal class Program
    {
        static void Main(string[] args)
        {
             vector n = new vector (3,4);
             vector m = new vector (3,4);
             vector t = new vector (6,8);
        t = n + m;
        Console.WriteLine("{0}", t.ToString());
        Console.ReadLine(); 







        }
    }

