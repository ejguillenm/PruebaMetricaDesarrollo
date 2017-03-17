using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la Opcion");
            Console.WriteLine("1. ChangeString");
            Console.WriteLine("2. CompleteRange");
            Console.WriteLine("3. MoneyPart");

            var opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Input:");
                    ChangeString change = new ChangeString();
                    change.Build(Console.ReadLine());
                    break;

                case "2":
                    Console.WriteLine("Input:");
                    CompleteRange complete = new CompleteRange();
                    complete.Build(Console.ReadLine());
                    break;

                case "3":
                    Console.WriteLine("Input:");
                    MoneyParts money = new MoneyParts();
                    money.Build(Console.ReadLine());
                    break;

            }
            
        }
    }
}
