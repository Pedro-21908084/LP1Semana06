namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        //controctor
        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}