using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct item
    {
        public int statBoost;
    }
   public class player
    {
       Random rand;

        private int item;
        private int inventory;
        private string _name;
        private int _gold = 0;
        private int _health = 10;
        private int _damage = 67;
        public int _shieldValue = 0;
        private int _arrow = 5;
        private int _potion = 5;
        public int _weaponValue = 1;
        private int _Gem = 9;
        private item[] _inventory;

        
        public int mods = 0;
        //influences the game to buy modifers
        public int GetHealth()
        {
            //for every mod the upper range of every power
            int upper = (2 * mods + 7);
            //means at the start the player will  have the lowest possible stats
            int lower = (mods + 2);
            return rand.Next(lower,upper);
        }

        //buy 
         bool Buy(int index,item _inventory)
        {

        }
        

        public void  Player(string nameVal, int healthVal, int damageVal, int inventorySize)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
            _inventory = new item[inventorySize];
        }
        public int GetPower()
        {
            //for every mod the upper range of every power
            int upper = (2 * mods + 3);
            //means at the start the player will  have the lowest possible stats
            int lower = (mods + 1);
            return rand.Next(lower, upper);
        }
       public int GetGold()
        {
                        return (_gold);
        }
        public bool Sell(player _player, int shopIndex, int playerIndex)
        {
          return  player.Buy(_inventory[shopIndex], playerIndex);
        }

    }
}

