using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication12
{
    class Car
    {
        public double pojemnoscSilnika;
        public string marka;
        static public int iloscKol;

       
        public Car()
        {
        }
       

        public Car(double pojemnoscSilnika, string marka)
        {  
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka; 
        }

        static public Car Create()
        {
            return Car obiekt; 
        }

        static Car()
        {
            iloscKol = 4;
        }

        


        
    }
}