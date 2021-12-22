using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Статические_методы
{
    static class Сircle
    {
        static public double GetSquareСircle(double r)
        { return r*r * Math.PI; }
        static public double GetLengthСircle(double r)
      { return 2 * Math.PI * r; }
        static public double GetPointСircle(double x, double y)
           
        { return Math.Sqrt(Math.Pow((x-0),2)+Math.Pow((y-0),2)) ;}
    }
}
