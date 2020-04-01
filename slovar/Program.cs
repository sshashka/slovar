using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slovar
{
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(1, "Ukraine");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                
            }
            int sum2 = countries.Sum(n => n.Key);
            Console.WriteLine(sum2);
            Console.ReadKey();
        }
    }
}
