using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IEnumerable
    {
        public static void Main()
        {
            List<int> numberList = new List<int> {1,2,3,4,5};
            foreach (int num in numberList) 
            {
                Console.WriteLine(num);
            }
            IEnumerable<int> numberEnumerable = GetNumberEnumerable();
            foreach (int num in numberEnumerable)
            {
                Console.WriteLine(num);
            }
        }
        public static IEnumerable<int> GetNumberEnumerable()
        {
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
            yield return 10;
        }
    }
}
