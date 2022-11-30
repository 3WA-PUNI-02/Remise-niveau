using System.Text;

namespace RedStudio.SuperRPGOTD
{
    public class HealthBar_EXAMPLE
    {
        // Champs / Field
        int _hp;
        int _maxHp;
        string _name;

        // Propriétés / Property
        public int HP { get => _hp; }
        public int MaxHp { get => _maxHp; }
        public string Name { get; private set; }

        // Methode / Method
        void Damage(int amount)
        {
            Name = "coucou";
            _hp -= amount;
        }
        public void Regen(int amount)
        {
            
        }
    }

    public class Player
    {
        HealthBar_EXAMPLE healthBar;

        void Main()
        {
            healthBar = new HealthBar_EXAMPLE();

            //_hb._hp = -12;

            Console.WriteLine(healthBar.HP);

            //healthBar.HP = 12;
        }
    }

}
