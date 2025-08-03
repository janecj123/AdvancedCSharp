using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// function extencion allows you to add new methods to existing types without modifying the original type or creating a new derived type.
// it also can add methods to bulid in types like string, int, etc.
//it basicly means that you can add methods to every existing class if you follow the syntax

namespace FunctionExtencion
{
    //public static void Main(string[] args)
    //{
    //    Player player = new Player();
    //    player.Name = "Hero"; // setting the player's name
    //    player.Start();
    //    player.MoveRight(5); // using the extension method to move the player to the right 5 steps


    //    int number = 10;
    //    number.AddFive();
    //    Console.WriteLine($"Number after adding five: {number}"); // using the extension method to add five to the number
    //}





public class Player
{
    public string Name { get; set; }
    public void Start()
    {
        Console.WriteLine("Player started!");
    }
}


public static class FunctionExtention
{

        //function need to be static and first parameter need to have this keyword and name of the class/type you want to extend
        //you can allso access Player properties and methods inside the extension method
        public static void MoveRight(this Player player, int distance)
    {
        Console.WriteLine($"Player moved to the right {distance} steps !");
        Console.WriteLine($"Player name is: {player.Name}");
    }

    public static int AddFive(this int number)
    {
        return number + 5;
    }
}

   

}
