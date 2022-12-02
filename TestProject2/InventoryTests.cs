using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class InventoryTests
    {

        [Test]
        public void CreateInventory()
        {
            Inventory inventory = new Inventory();

            Assert.IsNotNull(inventory);
            Assert.IsNotNull(inventory.Bag);
            Assert.AreEqual(0, inventory.Bag.Count);
        }

        [Test]
        public void CreateInventoryAndAddItem()
        {
            Inventory inventory = new Inventory();

            inventory.AddItem("Potion");

            Assert.AreEqual(1, inventory.Bag.Count);
            Assert.IsTrue(inventory.Bag[0] == "Potion");
        }

        [Test]
        public void CreateInventoryAndAdd3Items()
        {
            Inventory inventory = new Inventory();

            inventory.AddItem("Potion");
            inventory.AddItem("Epee");
            inventory.AddItem("Key");

            Assert.AreEqual(3, inventory.Bag.Count);
            Assert.IsTrue(inventory.Bag[0] == "Potion");
            Assert.IsTrue(inventory.Bag[1] == "Epee");
            Assert.IsTrue(inventory.Bag[2] == "Key");
        }

        [Test]
        public void CreateInventoryAndAdd1000Items()
        {
            Inventory inventory = new Inventory();

            for (int i = 0; i < 1000; i++)
            {
                inventory.AddItem("Potion");
            }

            Assert.AreEqual(1000, inventory.Bag.Count);
            for (int i = 0; i < inventory.Bag.Count; i++)
            {
                Assert.IsTrue(inventory.Bag[i] == "Potion");
            }
        }

        [Test]
        public void CreateInventoryAndAddNullItem()
        {
            Inventory inventory = new Inventory();

            Assert.Throws<ArgumentException>(() =>
            {
                inventory.AddItem(null);
            });
        }

        [Test]
        public void CreateInventoryAndAddEmptyItem()
        {
            Inventory inventory = new Inventory();

            Assert.Throws<ArgumentException>(() =>
            {
                inventory.AddItem("");
            });
        }

        [Test]
        public void CreateInventoryAndAdd3Potions()
        {
            Inventory inventory = new Inventory();

            inventory.AddItem("Potion", 3);

            Assert.AreEqual(3, inventory.Bag.Count);
            Assert.IsTrue(inventory.Bag[0] == "Potion");
            Assert.IsTrue(inventory.Bag[1] == "Potion");
            Assert.IsTrue(inventory.Bag[2] == "Potion");
        }

        [Test]
        [TestCase(-3)]
        [TestCase(0)]
        [TestCase(100)]
        public void CreateInventoryAndWeirdPotionsQuantity(int qt)
        {
            Inventory inventory = new Inventory();

            Assert.Throws<ArgumentException>(() =>
                inventory.AddItem("Potion", qt)
            );
        }





    }
}
