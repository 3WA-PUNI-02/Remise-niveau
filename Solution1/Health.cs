using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Health
    {
        // Constructeur
        public Health(int maxHealth)
        {
            if (maxHealth <= 0)
            {
                throw new ArgumentException();
            }
            _maxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public Health(int maxHealth, int health)
        {
            if (health > maxHealth || maxHealth <= 0 || health < 0)
            {
                throw new ArgumentException();
            }

            if(health == 0)
            {
                IsDead = true;
            }

            _maxHealth = maxHealth;
            CurrentHealth = health;
        }

        // Champs
        int _maxHealth;

        // Propriété
        public int MaxHealth        // Première manière d'écrire une propriété
        {
            get
            {
                return _maxHealth;
            }
        }
        public int CurrentHealth { get; private set; }
        public bool IsDead { get; private set; }

        // Methodes
        public void TakeDamage(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException();
            }

            CurrentHealth = CurrentHealth - amount;

            if(CurrentHealth < 0)
            {
                CurrentHealth = 0;
                IsDead = true;
            }

        }

        public void Heal(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException();
            }

            CurrentHealth = CurrentHealth + amount;

            if(CurrentHealth > 0)
            {
                IsDead = false;
            }

        }

    }
}
