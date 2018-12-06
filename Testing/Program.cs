using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseRectangle rectangle = new BaseRectangle(20, 10);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Center.ToString());

            Console.ReadKey();
        }
    }
}
