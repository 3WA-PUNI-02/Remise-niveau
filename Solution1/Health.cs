using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    public class Health
    {
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

        int _maxHealth;

        public int MaxHealth => _maxHealth;       // Première manière d'écrire une propriété
        public int CurrentHealth { get; private set; }
        public bool IsDead { get; private set; }

        public event Action OnDie;
        public event Action<int> OnHealthUpdate;

        public void TakeDamage(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException();
            }

            CurrentHealth = CurrentHealth - amount;
            OnHealthUpdate?.Invoke(CurrentHealth);

            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
                IsDead = true;
                OnDie?.Invoke();

                // Alternative
                //if(OnDie != null)
                //{
                //    OnDie.Invoke();
                //}
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
