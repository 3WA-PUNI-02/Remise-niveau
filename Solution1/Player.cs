using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Player
    {
        Health _healthBar;
        Inventory _inventory;

        public string Name { get; set; }

        public Health HealthBar { 
            get => _healthBar; 
            private set => _healthBar=value; }
        public Inventory Inventory { get => _inventory; private set => _inventory = value; }

        public Player(int initialLife)
        {
            Name = "|)4||2< >.< _Kev1 du 77__ :3";

            HealthBar = new Health(initialLife);
            Inventory = new Inventory(this);

            HealthBar.OnDie += ReactToDie;
            //HealthBar.OnHealthUpdate += HealthBar_OnHealthUpdate;
            
        }

        private void HealthBar_OnHealthUpdate(int obj)
        {
            throw new NotImplementedException();
        }

        private void ReactToDie()
        {
            Console.Write("aie");
        }

    }
}
