using C_Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    class InvenotryItem
    {
        public string Name { get; set; }



        public virtual void itemUse()
        {
            Console.WriteLine("Item was used.");
        }
    }

    class Sword : InvenotryItem
    {
        public int Damage { get; set; }
        public Sword(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public void Swing()
        {
            Console.WriteLine($"{Name} swings with {Damage} damage.");
        }

         public override void itemUse()
        {
            Swing();
        }
    }


    class Inventory<T> where T : InvenotryItem
    {
        public T Item { get; set; }

        public Inventory(T item)
        {
            Item = item;
        }

        public void UseItem()
        {
            Item.itemUse();
        }
    }
}


//public static void Main(string[] args)
//{
//    InvenotryItem item = new InvenotryItem { Name = "Health Potion" };
//    Sword sword = new Sword("Excalibur", 50);
//    Inventory<Sword> inventoryItem = new Inventory<Sword>(sword);
//    inventoryItem.UseItem();


//}