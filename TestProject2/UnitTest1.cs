using HelloWorld;

namespace TestProject2
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void HealthBarWorks()
        {
            HealthBar hb = new HealthBar(100);
            hb.Damage(10);
            Assert.IsTrue(hb.HP == 90);
        }

        [Test]
        public void HealthBarWorks2()
        {
            HealthBar hb = new HealthBar(100);
            Assert.Throws<ArgumentException>( () => { hb.Damage(-10); } );
        }

        [Test]
        public void HealthBarWorks3()
        {
            HealthBar hb = new HealthBar(100);
            hb.Damage(0);
            Assert.IsTrue(hb.HP == 100);
        }

    }
}