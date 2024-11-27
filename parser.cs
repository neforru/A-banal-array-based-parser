using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace parser
{

    class Pars
    {
        static public void Main()
        {
            string[] city =  {"Moscow", "Vladivostok", "Voronej", "Omsk", "Berlin", "London", "Krasnadar" };
            bool found = true;
            
            foreach (string item in city)
            {
                // Console.WriteLine(item);
                string search = Console.ReadLine();
                
                switch (city.Contains(search))
                {
                    case true:
                    {
                        Console.WriteLine(found + $"\n Значение найдено в массиве");
                    }
                    break;

                    case false:
                    {
                        Console.WriteLine("Значение не найдено в массиве");
                        
                    } break;

                        
                }
            }
        }
    }
}
