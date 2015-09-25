using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2. x = " + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);

            Console.ReadLine();
        } 
        
        static void Func1(int value)
        {

        } 
        
        static void Func2(int value)
        {
            value = value + 1;
        }

        static void Func3(int x)
        {
            x = x + 1;
        }    
    }
}
