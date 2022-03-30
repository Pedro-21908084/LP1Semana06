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
            string enemyNames = "";

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
                enemyNames += enemys[i].GetName() + "\n";
            }

            //print names
            Console.Write(enemyNames);
        }
    }
}
