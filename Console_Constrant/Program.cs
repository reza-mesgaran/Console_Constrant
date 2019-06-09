using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constrant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Area.Circle());
            Console.ReadKey();
        }
        
    }    

    public class Area
    {
        private const double PI = 3.14;
        public static double Circle()
        {
         Console.Write("Enter Radius of the Circle:");
         int Radius = int.Parse(Console.ReadLine());
         double area = (PI * Radius);           
         return area;
        }
    }
}