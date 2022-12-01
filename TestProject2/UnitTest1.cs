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
            Health hb = new Health(100);
            hb.Damage(10);
            Assert.IsTrue(hb.HP == 90);
        }

        [Test]
        public void HealthBarWorks2()
        {
            Health hb = new Health(100);
            Assert.Throws<ArgumentException>( () => { hb.Damage(-10); } );
        }

        [Test]
        public void HealthBarWorks3()
        {
            Health hb = new Health(100);
            hb.Damage(0);
            Assert.IsTrue(hb.HP == 100);
        }

    }
}