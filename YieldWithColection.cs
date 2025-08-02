using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeildWithColection;


//this is only ilustration how yield work
// better ussage would be on my own collection that doesn't have implemented iterator like List!!!!!!!!!!!!!!!!!!!!!!!
namespace YeildWithColection
{
    class Inventory : IEnumerable<InventoryItem>
    {
        private List<InventoryItem> items = new List<InventoryItem>();
        public void AddItem(InventoryItem item)
        {
            items.Add(item);
        }


        public void RemoveItem(InventoryItem item)
        {
            items.Remove(item);
        }

        public int InventorySize()
        {
            return items.Count;
        }
        public InventoryItem GetItem(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            return items[index];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new InventoryEnumerator(this);
        }

        IEnumerator<InventoryItem> IEnumerable<InventoryItem>.GetEnumerator()
        {
           return new InventoryEnumerator(this);
        }

        public class InventoryEnumerator : IEnumerator<InventoryItem> 
        {
           
            private int index = -1;
            private Inventory inventory;


            public InventoryEnumerator(Inventory inventory)
            {
                this.inventory = inventory;
            }

           

            object IEnumerator.Current => inventory.GetItem(index);

            InventoryItem IEnumerator<InventoryItem>.Current => inventory.GetItem(index);

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                
                this.index++;
                return index < inventory.InventorySize();
            }

            public void Reset()
            {
                index = -1;
            }

          
        }
    }

    class InventoryItem
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public void ItemUse()
        {
            Console.WriteLine("Item was used.");
        }

        public override string ToString()
        {
            return $"{Name} (Level: {Level})";
        }

    }
}


//public static void Main(string[] args)
//{

//    InventoryItem sword = new InventoryItem()
//    {
//        Name = "excalibur",
//        Level = 1
//    };
//    InventoryItem bow = new InventoryItem()
//    {
//        Name = "longbow",
//        Level = 1
//    };
//    InventoryItem bow1 = new InventoryItem()
//    {
//        Name = "shorBow",
//        Level = 1
//    };
//    Inventory inventory = new Inventory();
//    inventory.AddItem(sword);
//    inventory.AddItem(bow);
//    inventory.AddItem(bow1);

//    foreach (var item in inventory)
//    {
//        Console.WriteLine(item);
//    }


//}