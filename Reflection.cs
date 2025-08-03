using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// reflection is used to check if a class has a specific method, property or neasted another class at runtime
namespace Reflection

{
    public class Player
    {

        public class Inventory
        {

            private void AddItem(string item)
            {
                Console.WriteLine($"Adding {item} to inventory.");
            }
        }








    //public static void Main(string[] args)
    //{
    //    Player.Inventory inventory = new Player.Inventory();



    //    //typeof(Player).GetNestedType("Inventory").GetMethod("AddItem").Invoke(inventory, new object[] { "Sword" });

    //    //can access private method using reflection but need to add | System.Reflection.BindingFlags.Instance in get method parameters
    //    typeof(Player).GetNestedType("Inventory").GetMethod("AddItem", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(inventory, new object[] { "Sword" });

    //    // this is another way to access private method using reflection 
    //    //it is doing the as same as the above code but in a more verbose way
    //    Type inventoryType = typeof(Player).GetNestedType("Inventory");
    //    System.Reflection.MethodInfo methodInfo = inventoryType.GetMethod("AddItem", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
    //    methodInfo.Invoke(inventory, new object[] { "Shield" });


    //    // if Player.Inventory is a class that has a parameterless constructor, you can create an instance of it using Activator.CreateInstance
    //    if (inventoryType != null)
    //    {
    //        object inventoryObject = Activator.CreateInstance(inventoryType);

    //    }

    //}


}



}
