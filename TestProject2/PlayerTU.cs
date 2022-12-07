using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class PlayerTU
    {
        [Test]
        public void TestPlayer()
        {
            var p = new Player(100);
            var potion = new Potion(100);

            p.HealthBar.TakeDamage(150);

            p.Inventory.AddItem(potion);
            p.Inventory.UseItemFromInventory(potion);

            Assert.IsTrue(p.HealthBar.CurrentHealth == 100);
        }

        [Test]
        public void TestPlayerWithDifferentPotion()
        {
            Player p = new Player(200);
            Potion petitePotion = new Potion(50);
            Potion grandePotion = new Potion(100);

            p.HealthBar.TakeDamage(200);

            p.Inventory.AddItem(petitePotion);
            p.Inventory.AddItem(grandePotion);
            p.Inventory.UseItemFromInventory(petitePotion);

            Assert.IsTrue(p.HealthBar.CurrentHealth == 50);

            p.Inventory.UseItemFromInventory(grandePotion);

            Assert.IsTrue(p.HealthBar.CurrentHealth == 150);
        }


    }
}
