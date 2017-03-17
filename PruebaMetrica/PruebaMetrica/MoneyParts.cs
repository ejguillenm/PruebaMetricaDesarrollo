using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMetrica
{
    class MoneyParts
    {
        public void Build(string input)
        {
            var suma = Convert.ToDecimal(input);
            List<decimal> numbers = new List<decimal>() { 0.05m, 0.1m, 0.2m, 0.5m, 1m, 2m, 5m, 10m, 20m, 50m, 100, 200m };
            List<decimal> aux = numbers.OrderBy(x => x).ToList();

            sum_up(aux, suma);
        }

        private static void sum_up(List<decimal> numbers, decimal suma)
        {
            var lst = new List<string>();

            sum_up_recursive(numbers, suma, new List<decimal>(), lst);
            Console.ReadKey();
        }

        private static void sum_up_recursive(List<decimal> numbers, decimal suma, List<decimal> partial, List<string> lst)
        {
            decimal s = partial.Sum();

            if (s == suma)
            {
                var final = partial.OrderBy(x => x).ToArray();
                if (lst.IndexOf(string.Join(",", final)) == -1)
                {
                    Console.WriteLine("[" + string.Join(",", final) + "]");
                    lst.Add(string.Join(",", final));
                }
            }

            if (s >= suma)
                return;

            for (int i = 0; i < numbers.Count; i++)
            {

                var remaining = new List<decimal>();

                var lstPartial = new List<decimal>(partial);
                for (int nivel = i; nivel < numbers.Count; nivel++)
                {
                    decimal n = numbers[nivel];
                    lstPartial.Add(n);
                    sum_up_recursive(numbers, suma, lstPartial, lst);
                }
                for (int j = i + 1; j < numbers.Count; j++)
                    remaining.Add(numbers[j]);

                sum_up_recursive(remaining, suma, lstPartial, lst);

            }


        }
    }
}
