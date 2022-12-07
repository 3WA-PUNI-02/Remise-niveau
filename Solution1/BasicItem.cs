using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class BasicItem
    {
        protected int _buyCost;
        protected int _sellCost;
        protected int _name;

        public int SellCost 
        { 
            get => _sellCost; 
            protected set => _sellCost = value; 
        }

        public virtual void UseItem(Player p)
        {

            Console.WriteLine("On utilise un objet");

        }

    }


}
