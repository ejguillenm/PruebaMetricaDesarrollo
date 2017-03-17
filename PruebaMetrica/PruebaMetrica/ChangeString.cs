using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMetrica
{
    public class ChangeString
    {

        public void Build(string input)
        {
            var universoString = "a,b,c,d,e,f,g,h,i,j,k l m,n,ñ,o,p,q,r,s,t,u,v,w,x,y,z";

            var universoList = universoString.Split(',').ToList();

            var inputArray = input.ToCharArray().Select(x => x.ToString()).ToList();
            var result = string.Empty;

            ProcessingString(universoList, inputArray, result);

            Console.ReadKey();
        }

        private static string ProcessingString(List<string> universoChar, List<string> inputArray, string result)
        {
            foreach (var item in inputArray)
            {
                var index = universoChar.IndexOf(item.ToLower());
                if (index == -1)
                {
                    result = result + item;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item);
                }
                else
                {
                    var newIndex = index + 1;
                    newIndex = ValidateIndex(universoChar, newIndex);

                    if (char.IsUpper(item[0]))
                    {
                        result = result + universoChar[newIndex].ToUpper();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(universoChar[newIndex].ToUpper());
                    }
                    else
                    {
                        result = result + universoChar[newIndex];
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(universoChar[newIndex]);
                    }
                }
            }
            return result;
        }

        private static int ValidateIndex(List<string> universoChar, int newIndex)
        {
            if (newIndex >= universoChar.Count())
                newIndex = 0;
            return newIndex;
        }
    }

}