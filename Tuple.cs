using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    
    class Tuple
    {


        public (int, string, double, Player) GetTuple(int index)
        {
            (int, string, double, Player) tuple = index switch
            {
                1 => (1, "Hello", 3.14, new Player()),
                2 => (2, "World", 2.71, new Player()),
                _ => (0, "Unknown", 0.0, new Player())
            };


            return tuple;
        }

    }

    class Player { }


}
//public static void Main(string[] args)
//{
//    Tuple tuple = new Tuple();
//    var (index, name, number, player) = tuple.GetTuple(2);
//    Console.WriteLine($"Index: {index}, Name: {name}, Number: {number}, Player: {player}");

//}


