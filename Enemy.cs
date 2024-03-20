namespace MyGame
{
    public class Enemy
    {
        private string name;
        private int health;
        private float shield;

        public Enemy(string name)
        {
            SetName(name); 
            this.health = 100;
            this.shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public int GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }
        
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
    }
}
