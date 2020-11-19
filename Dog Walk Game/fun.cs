using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dog_Walk_Game
{
    public class fun
    {
         public void MaybeDogTreat(game G, Dog d, fun f, House h)
        { 
             WriteLine("You open the pantry. You see your dog food, but its all sealed up. But wait! There's one lone treat on the ground. Eat it? Y/N");
            ConsoleKeyInfo treat = ReadKey();
            ReadKey();
            if (treat.Key == ConsoleKey.Y)
            {
                 WriteLine("You eat the mystery treat");
                 WriteLine("....................");
                 WriteLine("..................................");
                 WriteLine(".....................................................");
                 WriteLine("it wasn't a dog treat. It was a peice of sponge.");
                 ForegroundColor = ConsoleColor.Red;
                 WriteLine("+1 Bad Dog Point");
                 ResetColor();
                 ReadKey();
                d.baddog++;
            }
           else if (treat.Key == ConsoleKey.N)
            {
                 WriteLine("Probably for the best");
                 ForegroundColor = ConsoleColor.Green;
                 WriteLine("+1 dogtreat");
                 ResetColor();
                ReadKey();
                d.dogtreats++;
            }
            else
            {
                 WriteLine("Invalid Input");
                MaybeDogTreat(G,d,f,h);
            }

        }

        public void RedBull(game G, fun f, Dog d, House h)
        {
             WriteLine("Take a Redbull? Y/N");
            ConsoleKeyInfo bull = ReadKey();
            if (bull.Key == ConsoleKey.Y)
            {
                 WriteLine("Your walk is sure to be longer now!");
                 ForegroundColor = ConsoleColor.Green;
                 WriteLine("+1 dogtreat");
                 ResetColor();
                d.dogtreats++;
                ReadKey();

            }
           else if (bull.Key == ConsoleKey.N)
            {
                 WriteLine("Those have way too much caffine. Unhealthy.");
                 ReadKey();
            }
            else
            {
                 WriteLine("Invalid Input");
                 RedBull(G,f,d,h);
            }

        }
        public void CouchChange(game G, fun f, Dog d, House h) 
        {
             WriteLine("You look in the couch cushions and find $2 in quarters. Maybe your human will buy you a snack!");
             ForegroundColor = ConsoleColor.Green;
             WriteLine("+1 dogtreat");
             ResetColor();
            d.dogtreats++;
            ReadKey();
            h.LivingRoom(G, f, d, h);

        }
        public void uhoh(game G, fun f, Dog d, House h)
        {
             WriteLine("You tug the leash, only to realize its a TV plug! Its already too late. The TV is shattered on the floor. Someone's in the doghouse now.");
             ForegroundColor = ConsoleColor.Red;
             WriteLine("+2 Bad Dog Points");
             ResetColor();
            d.baddog++;
            d.baddog++;
            ReadKey();
            h.LivingRoom(G, f, d, h);
        }

        }

    }


