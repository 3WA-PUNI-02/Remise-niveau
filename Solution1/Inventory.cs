using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /// <summary>
    /// Gère le sac du joueur, et permet d'utiliser les objets en jeu
    /// </summary>
    public class Inventory
    {
        List<string> _bag;

        public List<string> Bag
        {
            get { return _bag; }
            private set { _bag = value; }
        }

        public Inventory()
        {
            _bag = new List<string>();
        }

        public void AddItem(string newItem)
        {
            if (string.IsNullOrEmpty(newItem))
            {
                throw new ArgumentException();
            }

            Bag.Add(newItem);
        }
        public void AddItem(string newItem, int unit)
        {
            if(unit <= 0 || unit >= 100)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < unit; i++)
            {
                AddItem(newItem);
            }
        }

        public void RemoveItem(string itemToRemove)
        {
            //if (!_bag.Contains(itemToRemove))
            if (_bag.Contains(itemToRemove) == false)
            {
                throw new ArgumentException();
            }

           _bag.Remove(itemToRemove);
        }

        public void RemoveItem(string itemToRemove, int qt)
        {
            if(qt <= 0 )
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < qt; i++)
            {
                RemoveItem(itemToRemove);
            }
        }



        public void UseItem()
        {
            //RemoveItem();
        }

        public void SellItem()
        {
            //RemoveItem();
        }
    }
}
