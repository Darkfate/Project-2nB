namespace GameCore.Actors.Interfaces
{
    public abstract class LevelCore
    {
        public LevelCore()
        {
            Level = 1;
            NextLevel = 10;
        }

        public void AddExp(int amount)
        {
            Exp += amount;
            _checkForLevelUp();
        }

        #region private method

        private void _checkForLevelUp()
        {
            if (Exp >= NextLevel)
            {
                _levelUp();
            }
        }

        private void _levelUp()
        {
            Level++;
            NextLevel = NextLevel + (int)(NextLevel * _multiplier);
            _levelUpEvent();
        }

        protected abstract void _levelUpEvent();

        #endregion private method

        #region Properties

        public int Level { get; private set; }

        public int Exp { get; private set; }

        public int NextLevel { get; private set; }

        private const double _multiplier = 1.2;

        #endregion Properties
    }
}