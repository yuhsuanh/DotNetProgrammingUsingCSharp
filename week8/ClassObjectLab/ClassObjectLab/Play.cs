using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    class Play
    {
        public Terrain[,] terrains  = new Terrain[4,4] ;
        public Terrain location;
        private Player player = new Player();
        int x=0;
        int y=0;

        public Play()
        {
            var r = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    terrains[i, j] = new Terrain(r.Next(0, 3));
                }
            } 
            location = terrains[x,y];

            Console.WriteLine("hit enter to start");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Enter)
            {
                ConsoleKeyInfo cki = new ConsoleKeyInfo();

                do
                {
                    Console.WriteLine("\nPress a key to display; press the 'x' key to quit."); 

                    //Your code could perform some useful task in the following loop. However, 
                    //for the sake of this example we'll merely pause for a quarter second.

                    while (Console.KeyAvailable == false)
                        Thread.Sleep(250); // Loop until input is entered.
                    cki = Console.ReadKey(true);
                    Console.WriteLine("You pressed the '{0}' key.", cki.Key);

                    // 1 change terrain locaionts ; Send terrain to player   

                    switch (cki.Key)
                    { 
                        case ConsoleKey.LeftArrow:
                            if (x>0)
                            { 
                                x--; 
                            } 
                            break;
                        case ConsoleKey.UpArrow:
                            if (y < 3)
                            {
                                y++;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (x < 3 )
                            {
                                x++;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (y > 0)
                            {
                                y--;
                            }
                            break;
                        default:
                            break;
                    } 
                    location = terrains[x, y];

                    Console.WriteLine("New position:{0},{1}", x, y);
                    Console.WriteLine("terrains value{0}", terrains[x, y].land);
                    player.Check(terrains[x, y]);
                    Console.WriteLine("Player strength:{0}",player.strength);
                    Console.WriteLine("You pressed the '{0}' key.", cki.Key);


                } while (cki.Key != ConsoleKey.X);
            }
        }
        }

        //hit enter to start  
        //if (info==ConsoleKey)
	    // { 
	     // } 
         //4 arrows  , 1 change terrain locaionts ; Send terrain to player   
    } 
 
