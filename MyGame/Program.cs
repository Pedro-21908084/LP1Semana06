using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int enemyNumber;
            Enemy[] enemys;
            string enemyName, everyName;

            //ask enemy numbers
            Console.Write("Number of enemys: ");
            enemyNumber = int.Parse(Console.ReadLine());

            //create array
            enemys = new Enemy[enemyNumber];

            //ask names of enemys

            //print names
            Console.WriteLine($"You chose {enemyNumber} enemys.");
        }
    }
}
