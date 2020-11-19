using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dog_Walk_Game
{
    public class House
    {
        public int Kitchen(game G,fun f, Dog d, House h)
        {
            Clear();
             WriteLine("You make your way to the kitchen");
             WriteLine("What area would you like to search?");
             WriteLine(" A: Fridge");
             WriteLine(" B: Sink");
             WriteLine(" C: Pantry");
             WriteLine(" D: Leave Kitchen");
            ConsoleKeyInfo kitchen = ReadKey();
            ReadKey();
            if (kitchen.Key == ConsoleKey.A) 
            {
                 Clear();
                 WriteLine("You open up the fridge. Nothing in here but a six pack of Redbull and a half empty pickle jar.");
                 WriteLine("Jeez. Your human lives like this?");
                f.RedBull(G,f,d,h);
                Kitchen(G, f, d, h);
            }
           else if (kitchen.Key == ConsoleKey.B)
            {
                 Clear();
                 WriteLine("Seems like you've tried everything INCLUDING the kitchen sink. Except you clearly haven't. You're still playing this game.");
                ReadKey();
                Kitchen(G,f,d,h);
            }
          else if (kitchen.Key == ConsoleKey.C)
            {
                 Clear();
                f.MaybeDogTreat(G,d,f,h);
                Kitchen(G,f,d,h);
       
            }
           else if (kitchen.Key == ConsoleKey.D)
            {
                 Clear();
                G.RoomChoice1(G,f,d,h);
            }
            else
            {
                 WriteLine("Invalid input");
                 Kitchen(G,f,d,h);
            }
            return 0;

        }
        public int LivingRoom(game G,fun f, Dog d, House h)
        {
            Clear();
             WriteLine("You enter the living room. Where do you look?");
             WriteLine(
                " A: Couch" +
                " B: Chair" +
                " C: TV Stand" +
                " D: Leave Living Room");
            ConsoleKeyInfo livingroom = ReadKey();
            ReadLine();

            if (livingroom.Key == ConsoleKey.A)
            {
                Clear();
                WriteLine("You jump on the couch and hear a jingle. Investigate? Y/N");
                ConsoleKeyInfo couch = ReadKey();
                ReadLine();
                if (couch.Key == ConsoleKey.Y)
                {
                    f.CouchChange(G,f,d,h);
                    LivingRoom(G,f, d,h);
                }
                else if (couch.Key == ConsoleKey.N)
                {
                     WriteLine("You didn't find anything.");
                    ReadKey();
                    LivingRoom(G, f, d, h);
                }
                else
                {
                     WriteLine("Invalid Input");
                     LivingRoom(G,f, d,h);
                }
            }
           else if (livingroom.Key == ConsoleKey.B)
            {
                Clear();
                WriteLine("You look under the chair. Empty.");
                 ReadKey();
                 ForegroundColor = ConsoleColor.Red;
                 WriteLine("WAIT!!");
                 ResetColor();
                 ReadKey();
                 WriteLine("Nope, sorry, thought I saw it but it was just some loose fabric");
                 ReadKey();
                LivingRoom(G,f, d,h);
            }
          else  if (livingroom.Key == ConsoleKey.C)
            {
                Clear();
                WriteLine("You look behind the TV and see something. Hey!! That might be it!!");
                 WriteLine("Pull? Y/N");
                ConsoleKeyInfo pull = ReadKey();
                ReadKey();

                if (pull.Key == ConsoleKey.Y)
                {
                    f.uhoh(G,f,d,h);
                }
               else if (pull.Key == ConsoleKey.N)
                {
                     WriteLine("You're about to tug on the leash, when you suddenly realize its a TV cord!! Thank God you didn't pull");
                     ForegroundColor = ConsoleColor.Green;
                     WriteLine("+1 dogtreat");
                     ResetColor();
                    d.dogtreats++;
                    ReadKey();
                    LivingRoom(G, f, d, h);
                }
                else
                {
                    WriteLine("Invalid input");
                    LivingRoom(G, f, d,h);
                }
                
            }
            else if (livingroom.Key == ConsoleKey.D)
            {
                 Clear();
                G.RoomChoice1(G,f,d,h);
            }
            else
            {
                 WriteLine("Invalid Input");  
                LivingRoom(G, f, d,h);
            }
            return 0;
        }
        public int Bathroom(game G, fun f, Dog d, House h)
        {
             Clear();
             WriteLine("You enter the bathroom. Where do you look?");
             WriteLine("" +
                " A: Toilet" +
                " B: Under sink" +
                " C: Laundry Hamper" +
                " D: Leave Bathroom");
            ConsoleKeyInfo bathroom = ReadKey();
            ReadLine();

            if (bathroom.Key == ConsoleKey.A)
            {
                Clear();
                WriteLine("You look inside the toilet bowl. Nothing here but water. Drink? Y/N");
                ConsoleKeyInfo drink = ReadKey();
                ReadLine();
                if (drink.Key == ConsoleKey.Y)
                {
                     WriteLine("You lap up some of the toilet water. You're disgusting.");
                     ReadKey();
                     ForegroundColor = ConsoleColor.Red;
                     WriteLine("+1 Bad Dog Point");
                     ResetColor();
                    d.baddog++;
                    ReadKey();
                     Clear();
                    Bathroom(G,f, d,h);
                }
               else if (drink.Key == ConsoleKey.N) 
                {
                     WriteLine("thank god.");
                     ReadKey();
                     Clear();
                     Bathroom(G, f, d,h);
                }
                else
                {
                     WriteLine("Invalid input");
                     Bathroom(G,f,d,h);

                }
            }

            if (bathroom.Key == ConsoleKey.B)
            {
                Clear();
                WriteLine("You push open the cabinet door. Nothing but cleaner in here.");
                 ReadKey();
                Bathroom(G,f,d,h);
            }
           else if (bathroom.Key == ConsoleKey.C)
            {
                Clear();
                WriteLine("You knock over the hamper in the corner. It reeks. Yikes. Root through it? Y/N");
                Hamper(G,d,f,h);
            }
           else if (bathroom.Key == ConsoleKey.D)
            {
                 Clear();
                G.RoomChoice1(G,f,d,h);
            }
            else
            {
                WriteLine("Invalid input");
                Bathroom(G,f, d,h);
            }
            return 0;
        }
        public int Bedroom(game G,fun f, Dog d, House h)
        {
            Clear();
            WriteLine("You enter the bedroom. Where do you look?");
             WriteLine("" +
                "A: Nightstand" +
                " B: Bed" +
                " C: Dresser" +
                " D: Leave Bedroom");
            ConsoleKeyInfo bedroom = ReadKey();
            ReadKey();

            if (bedroom.Key == ConsoleKey.A)
            {
                Clear();
                WriteLine("You look on top of the nightstand. There's no leash, but you find your human's fitbit! Take? Y/N");
                ConsoleKeyInfo fitbit = ReadKey();
                ReadKey();
                if (fitbit.Key == ConsoleKey.Y)
                {
                     WriteLine("As you grab the fitbit you realize its long dead. Oh well. Its the thought that counts, right?");
                     ForegroundColor = ConsoleColor.Green;
                     WriteLine("+1 dogtreat");
                     ResetColor();
                    d.dogtreats++;
                    ReadKey();
                    Bedroom(G,f, d,h);
                }
               else if(fitbit.Key == ConsoleKey.N)
                {
                     WriteLine("You know your human never uses it anyway.");
                    ReadKey();
                    Bedroom(G,f, d,h);
                }
                else
                {
                    WriteLine("Invalid input");
                    Bedroom(G,f, d,h);
                }

            }
          else  if (bedroom.Key == ConsoleKey.B)
            {
                Clear();
                WriteLine("You hop onto the middle of the bed, as per usual. You dont see anything, but it's really comfy.");
                 WriteLine("Hmm couldn't hurt to take a quick nap, could it? Y/N");
                Zzz(G,d,f, h);
            }
           else if (bedroom.Key == ConsoleKey.C)
            {
                Clear();
                WriteLine("One of the drawers is slightly open. Look inside? Y/N");
                Dresser(G,d,f,h);
            }
           else if (bedroom.Key == ConsoleKey.D)
            {
                 Clear();
                G.RoomChoice1(G, f, d,h);
            }
            else
            {
                 WriteLine("Invalid input");
                Bedroom(G,f, d,h);
            }
            return 0;
        }
        public void Hamper(game g, Dog d, fun f, House h)
        {
            ConsoleKeyInfo clothes = ReadKey();
            ReadKey();
            if (clothes.Key == ConsoleKey.Y)
            {
                WriteLine("You root through the dirty laundry. Its horrible. But after some digging you see it. Could it be?");
                ForegroundColor = ConsoleColor.DarkBlue;
                WriteLine("Maybe");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("IT IS!!!!!");
                ForegroundColor = ConsoleColor.Cyan;
                ResetColor();
                WriteLine("You found the leash! Now you can go back to your human and have a great walk!");
                ReadKey();
                End(d);

            }

           else if (clothes.Key == ConsoleKey.N)
            {
                WriteLine("Too nasty. Pass.");
                ReadKey();
                Bathroom(g,f,d,h);
            }
            else
            {
                WriteLine("Invalid Input");
                Hamper(g, d,f,h);
            }

        }
        public int Dresser( game G, Dog d, fun f, House h)
        {
            ConsoleKeyInfo open = ReadKey();
            ReadKey();
            if (open.Key == ConsoleKey.Y)
            {
                WriteLine("wow, perv.");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("+1 Bad Dog Point");
                ResetColor();
                d.baddog++;
                ReadKey();
                Bedroom(G,f,d,h);
            }
          else if (open.Key == ConsoleKey.N)
            {
                WriteLine("Way to respect privacy");
                ReadKey();
                Bedroom(G,f,d, h);
            }
            else
            {
                WriteLine("Invalid input");
                Dresser(G,d,f,h);
            }
            return 0;
        }
        public void Zzz( game G, Dog d, fun f, House h)
        {
            ConsoleKeyInfo sleepy = ReadKey();
            ReadKey();
            if (sleepy.Key == ConsoleKey.Y)
            {
                WriteLine("You settle in and close your eyes for a quick rest. Ah luxury... Wake up? Y/N");
                Zzz2( G,d, f,h);
            }

           else if (sleepy.Key == ConsoleKey.N)
            {
                WriteLine("Probably a good choice");
                ReadKey();
                Bedroom(G, f, d, h);

            }
            else
            {
                WriteLine("Invalid Input");
                Zzz(G, d, f, h);
            }


        }
        public void Zzz2(game G, Dog d, fun f, House h)
        {

            ConsoleKeyInfo oof = ReadKey();
            if (oof.Key == ConsoleKey.Y)
            {
                WriteLine("Great! Now you're rested too!");
                ForegroundColor = ConsoleColor.Green;
                WriteLine("+1 dogtreat");
                ResetColor();
                ReadKey();
                d.dogtreats++;
                Bedroom(G, f, d, h);
            }

           else if (oof.Key == ConsoleKey.N)
            {
                WriteLine("Oh no!! You overslept and its dark out. You missed your perfect walk");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("GAME OVER");
                ReadKey();
                ResetColor();
                Clear();
                Environment.Exit(0);

            }
            else
            {
                WriteLine("Invalid Input");
                Zzz2(G,d,f,h);
            }
         }
        public void End(Dog dog)
        {

            if (dog.dogtreats == dog.baddog)
            {
                WriteLine("You brought your leash to your owner and went on a great walk! How fun!");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("THE END! Thanks for playing, " + dog.name + "!");
                ReadKey();
                Environment.Exit(0);
            }
           else if (dog.baddog < dog.dogtreats)
            {
                WriteLine("Your walk was the best walk ever! You got to go to all your favorite places!!");
                WriteLine("You really are the best dog in the world, " + dog.name + "!");
                ForegroundColor = ConsoleColor.Green;
                WriteLine("THE END! Thanks for playing, " + dog.name + "!");
                ReadKey();
                Environment.Exit(0);

            }
          else if (dog.baddog > dog.dogtreats)
            {
                WriteLine("Wow. Your friend was really dissapointed in you. The walk was short and boring.");
                WriteLine("You'll be sure to do better next time, right???");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("THE END! Thanks for playing, " + dog.name + "!");
                ReadKey();
                Environment.Exit(0);
            }

        }

    }
    }
