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

        public Player()
        {
            Name = "|)4||2< >.< _Kev1 du 77__ :3";

            HealthBar = new Health(100);
            Inventory = new Inventory(this);

            HealthBar.OnDie += ReactToDie;

            //_healthBar.OnDie -= ReactToDie;

        }

        private void ReactToDie()
        {
            Console.Write("aie");
        }

    }
}
