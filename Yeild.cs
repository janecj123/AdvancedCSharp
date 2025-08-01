using C_Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    class Yeild
    {
       

        public Yeild()
        {
          
        }
        public IEnumerable<string> GetYeildList()
        {

            for (int i = 0; i < 1_000_000; i++)
            {
               yield return $"Item {i}";
            }
        }
    }
}

//public static void Main(string[] args)
//{
//    Yeild yeild = new Yeild();




//    foreach (var item in yeild.GetYeildList())
//    {
//        Console.WriteLine($"{item}");
//    }



//}

