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

            //ask enemy numbers
            Console.Write("Number of enemys: ");
            enemyNumber = int.Parse(Console.ReadLine());

            //create array
            enemys = new Enemy[enemyNumber];

            //ask names of enemys
            for (int i = 0; i < enemyNumber; i++)
            {
                Console.Write($"Name of enemy number {i+1}: ");
                enemys[i] = new Enemy(Console.ReadLine());
            }

            //print names
            Console.WriteLine($"You chose {enemyNumber} enemys.");
        }
    }
}
