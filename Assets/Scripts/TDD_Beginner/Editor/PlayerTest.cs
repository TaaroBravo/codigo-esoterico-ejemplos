using NUnit.Framework;

namespace TDD.Editor
{
    public class PlayerTest
    {
        [Test]
        public void start_with_initial_life()
        {
            var initialLife = 100;
            var player = new Player(initialLife);
            Assert.AreEqual(initialLife, player.GetLife());
        }

        [Test]
        public void reduce_life_when_receives_attack()
        {
            var initialLife = 100;
            var player = new Player(initialLife);

            player.ReceiveDamage(10);
            
            Assert.AreEqual(90, player.GetLife());
        }

        [Test]
        public void prevent_reduce_life_below_zero()
        {
            var initialLife = 100;
            var player = new Player(initialLife);

            player.ReceiveDamage(10000);
            
            Assert.AreEqual(0, player.GetLife());
        }
    }
}