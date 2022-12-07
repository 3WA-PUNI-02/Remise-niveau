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
        List<BasicItem> _bag;
        Player _player;

        public List<BasicItem> Bag
        {
            get { return _bag; }
            private set { _bag = value; }
        }

        public Inventory()
        {
            _bag = new List<BasicItem>();
        }

        public Inventory(Player master)
        {
            _bag = new List<BasicItem>();
            _player = master;
        }

        public void AddItem(BasicItem newItem)
        {
            if (newItem == null)
            {
                throw new ArgumentException();
            }

            Bag.Add(newItem);
        }
        public void AddItem(BasicItem newItem, int unit)
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

        public void RemoveItem(BasicItem itemToRemove)
        {
            //if (!_bag.Contains(itemToRemove))
            if (_bag.Contains(itemToRemove) == false)
            {
                throw new ArgumentException();
            }

           _bag.Remove(itemToRemove);
        }

        public void RemoveItem(BasicItem itemToRemove, int qt)
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

        public void UseItemFromInventory(BasicItem itemName)
        {
            if (_bag.Contains(itemName) == false) return;

            itemName.UseItem(_player);

            //if(itemName)
            //{
            //    _player.HealthBar.Heal(100);
            //}

            RemoveItem(itemName);
        }

        public void SellItem()
        {
            //RemoveItem();
        }
    }
}
