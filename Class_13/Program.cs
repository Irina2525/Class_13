using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("улица Кирова, дом 25, квартира 6", 25, 15, 30); // экземпляр класса 
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("проспект Металлургов, дом 37, квартира 10", 50, 30, 25, 10);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }


    }
}
    