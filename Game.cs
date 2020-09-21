using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Game
    {
        public struct  item
        {
            public int statBoost;
        }
        //Run the game
        public void Run()
        {

        }

        public  void PrintInventory(item[] items)
        {
            
        }
        //Performed once when the game begins
        public void Start()
        {

        }

        //Repeated until the game ends
        public void Update()
        {

        }

        public void Runshop(player p)
        {
            int _weaponP;
            int _ShieldP;
            int _arrowP;


            while (true)
            {
                int _arrowP = 7 + 1;
                int _GemP = 20 + 10 * p.mods;
                int _shieldP = 100 * p._shieldValue;
                int _WeaponP = 100 * (p._weaponValue + 1);
                Console.Clear();
                Console.WriteLine("     Welcome to the shop Sponge me boy Bob   ");
                Console.WriteLine("                    _+_+_+_+ We Have _+_+_+_+                                          ");
                Console.WriteLine("_+ Arrow +_(A): $ " + _arrowP);
                Console.WriteLine("_+ Shield +_(S): $ " + _shieldP);
                Console.WriteLine("_+ Gem +_(G): $ " + _GemP);


                // wait for input
                string input = Console.ReadLine().ToLower();
                if (input == "A" || input == "Arrow")
                {

                }
                else if (input == "G" || input == "Gem")
                {

                }

                else if (input == "S" || input == "Shield")
                {

                }

            }
        }

        public void OpenShopMenu(player p)
        {
            _shieldMod = p._shieldValue;
            _arrowMod = p._weaponValue;

            Runshop(p);

        }
        public void InitializeItems()
        {

        }

    
    
    
    
        //Performed once when the game ends
        public void End()
        {
            
        }
    
    
    
    
    
    }
}



