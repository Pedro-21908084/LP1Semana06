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
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName() => name;
        public float GetHealth() => health;
        public float GetShield() => shield;

        public void SetName(string name) => this.name = name.Trim();

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0)
                    health = 0;
            }
        }

        public void PickupPowerUp(PowerUp power, float amount)
        {
            switch (power)
            {
                case PowerUp.Health:
                    health + amount;
                    if(health > 100) health = 100;
                    break;
                case PowerUp.Shield:
                    shield + amount;
                    if(shield > 100) shield = 100;
                    break;
            }
        }
    }
}