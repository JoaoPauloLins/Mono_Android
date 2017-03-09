using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Player
{
    public class DeathCounter
    {
        private int _deathCounter;

        public int Deaths
        {
            get
            {
                return _deathCounter;
            }
        }

        public void IncreaseDeath()
        {
            _deathCounter++;
        }

        public void ResetDeaths()
        {
            _deathCounter = 0;
        }

        private static DeathCounter _instance;

        public static DeathCounter Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DeathCounter();

                return _instance;
            }
        }
    }
}
