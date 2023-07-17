using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new List<string>();
            countries.Add("India");
            countries.Add("Asia");
            countries.Add("Europe");
            countries.Add("Africa");
            foreach (var country in countries)
            {
                Console.WriteLine(country);

            }
        }
    }
}