namespace TDD
{
    public class Player
    {
        private float _life;

        public Player(float initialLife)
        {
            _life = initialLife;
        }

        public float GetLife() => _life;

        public void ReceiveDamage(int damage)
        {
            _life -= damage;

            if (_life < 0)
                _life = 0;
        }
    }
}