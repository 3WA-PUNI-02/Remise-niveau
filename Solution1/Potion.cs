using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Potion : BasicItem
    {
        int _regenAmount;

        public Potion(int regenAmount)
        {
            _regenAmount = regenAmount;
        }

        public override void UseItem(Player player)
        {
            base.UseItem(player);

            player.HealthBar.Heal(_regenAmount);
        
        }
    }


}
