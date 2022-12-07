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
            var p = new Player();

            p.HealthBar.TakeDamage(150);

            //p.Inventory.AddItem("Potion");
            //p.Inventory.UseItem("Potion");


            Assert.IsTrue(p.HealthBar.CurrentHealth == 100);


        }



    }
}
