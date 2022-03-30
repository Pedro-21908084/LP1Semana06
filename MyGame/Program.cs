using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int enemyNumber;

            //ask enemy numbers
            Console.Write("Number of enemys: ");
            enemyNumber = int.Parse(Console.ReadLine());
            //create array
            //ask names of enemys
            //print names
            Console.WriteLine($"You chose {enemyNumber} enemys.");
        }
    }
}
