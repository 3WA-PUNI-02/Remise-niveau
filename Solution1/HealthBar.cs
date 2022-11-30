using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class HealthBar
    {
        public HealthBar(int hp)
        {
            HP = hp;

        }

        public int HP { get; set; }

        public void Damage(int v)
        {
            if (v < 0) throw new ArgumentException();
            HP -= v;
        }
    }
}
