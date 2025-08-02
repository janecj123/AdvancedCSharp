using C_Advanced;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{

    class Player : IEnumerable<PlayerStats>
    {
        public PlayerStats Wisdom = new PlayerStats { Name = "Wisdom", Level = 1 };
        public PlayerStats Strength = new PlayerStats { Name = "Strength", Level = 1 };
        public PlayerStats Agility = new PlayerStats { Name = "Agility", Level = 1 };

        public IEnumerator<PlayerStats> GetEnumerator()
        {
            yield return Wisdom;
            yield return Strength;
            yield return Agility;
        }

      

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class PlayerStats 
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }




}

//public static void Main(string[] args)
//{

//    Player player = new Player();
//    foreach (var stat in player)
//    {
//        Console.WriteLine($"Stat: {stat.Name}, Level: {stat.Level}");
//    }

//}