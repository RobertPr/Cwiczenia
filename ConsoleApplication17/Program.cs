using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obiekt = new Car();
            Car obiekt2 = new Car(10, "mazda");

            System.Console.WriteLine(obiekt2);
            System.Console.WriteLine(obiekt2.pojemnoscSilnika);
            System.Console.WriteLine(obiekt2.marka);

            System.Console.ReadKey();

            Car obiekt3 = Car.Create();


        }
    }
}