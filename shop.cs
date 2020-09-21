using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public  class Shop
    {
        struct cost 
        {
          
        }

        public int _gold = 0;
       public  int _shieldMod;
       public  int _arrowMod;
         //gets called when the player runs away                        //refrences the palyer purchase
        public  void OpenShopMenu(player p)
        {
            _shieldMod = p._shieldValue;
            _arrowMod = p._weaponValue;

     

        }
        public void TryBuy(string item, int cost, player p)
        {
           if(p.GetGold() >= cost)
            {
                
            }
        }
        

        
      
    }
}
