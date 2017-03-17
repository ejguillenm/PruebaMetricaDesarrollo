using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMetrica
{
    public class CompleteRange
    {
        public void Build(string input)
        {

            var inputList = input.Split(',').Select(x => Convert.ToInt32(x)).ToList();

            var maxValue = inputList.Max(x => x);

            for (var i = 1; i < maxValue + 1; i++)
            {
                if (inputList.IndexOf(i) != -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i + ",");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i + ",");
                }
            }
            Console.ReadKey();

        }
    }
}