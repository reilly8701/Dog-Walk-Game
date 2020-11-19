using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dog_Walk_Game
{
    public class game
    {
      public  Dog dog = new Dog();
      public House house = new House();
      public fun Fun = new fun();

        public void MainMenu(game G, fun f, Dog d, House h)
        {
            string prompt = @"
██████╗  ██████╗  ██████╗     ██╗    ██╗ █████╗ ██╗     ██╗  ██╗██╗██╗
██╔══██╗██╔═══██╗██╔════╝     ██║    ██║██╔══██╗██║     ██║ ██╔╝██║██║
██║  ██║██║   ██║██║  ███╗    ██║ █╗ ██║███████║██║     █████╔╝ ██║██║
██║  ██║██║   ██║██║   ██║    ██║███╗██║██╔══██║██║     ██╔═██╗ ╚═╝╚═╝  
██████╔╝╚██████╔╝╚██████╔╝    ╚███╔███╔╝██║  ██║███████╗██║  ██╗██╗██╗
╚═════╝  ╚═════╝  ╚═════╝      ╚══╝╚══╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝╚═╝ 
                         |\_/|                  
                         | @ @    
                         |   <>              _  
                         |  _/\------____   | |
                         |               `--' |   
                       __|_       ___|   |___.' 
                    /_/_____/____/_______|                       
";
            string[] choices = { "Start", "Credits", "Exit" };
            Menu m = new Menu(prompt, choices);
            Title = "Dog Walk!";
            int Chosen = m.Run();
            switch (Chosen)
            {
                case 0:
                    StartGame(G,f,d,h);
                        break;
                case 1:
                    Credits(G,f,d,h);
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }

        }
        public void StartGame(game G, fun f, Dog d, House h)
        {

            Clear();
            WriteLine("Welcome to Dog Walk! Play as a dog and find your leash! " + "Press Enter to continue");
            while (ReadKey().Key != ConsoleKey.Enter) { } 
            Clear();
            NameCharacter(G,f,d,h);
        }
        public void Credits(game G, fun f, Dog d, House h)
        {
            Clear();
            WriteLine("Game developed by Maura Reilly");
            WriteLine("Uses assets from: ");
            WriteLine("Programming is Fun Adventure Game tutorials");
            WriteLine("Professor Mike Hadley's keyboard controlled menu");
            WriteLine("while key referenced from Microsoft");
            WriteLine("and made with some tutoring assistance from Ishan Dutta, Brendan Lienau, Rafael Santana, and Janell");
            WriteLine("Title asset from http://patorjk.com/software/taag/#p=moreopts&f=ANSI%20Shadow&t=Dog%20Walk!!");
            WriteLine("AASCII dog by unknown artist from https://www.asciiart.eu/animals/dogs");
            WriteLine("Press any key to return to menu");
            ReadKey(true);
            MainMenu(G,f,d,h);
        }
      public void NameCharacter(game G, fun f, Dog d, House h) 
        {
            WriteLine("Let's start by naming your dog!");
            dog.name = ReadLine();
            Clear();
            if (dog.name == "Lenny") 
            {
                WriteLine("Hey! Thats my dogs name!");
                ForegroundColor = ConsoleColor.Green;
                WriteLine("+1 dogtreat");
                dog.dogtreats++;
                ResetColor();
                ReadKey();
                Clear();

            }
            else if (dog.name == "Austin")
            {
                WriteLine("Hey! Thats my dogs name!");
                ForegroundColor = ConsoleColor.Green;
                WriteLine("+1 dogtreat");
                dog.dogtreats++;
                ResetColor();
                ReadKey();
                Clear();
            }
           else if (dog.name == "Hank") 
            {
                 WriteLine("Well that's my axolotl's name. But I guess I'll allow it, press any key to continue.");
                ForegroundColor = ConsoleColor.Green;
                WriteLine("+1 dogtreat");
                ResetColor();
                dog.dogtreats++;
                ReadKey();
            }
            else
            {
                 WriteLine("Alright " + dog.name + " press any key to begin!");
                 ReadKey();
                 Clear();
            }
            Write("You wake up from your afternoon nap to the sound of jingling keys. It's your best friend! They're finally home! You rush to the door to say hello, and amist all your excitement you make out one of your FAVORITE WORDS");
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            Write("'You wanna go for a W-A-L-K?'");
            ReadKey();
            ResetColor();
            WriteLine(" they say. Your tail wags with excitement.");
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("'Huh. That's odd...'");
            WriteLine("'I could've sworn I left the leash by the door. Can you find it?");
            ReadKey();
            ResetColor();
            RoomChoice1(G,f,d,h);
        }

        public void RoomChoice1(game G, fun f, Dog d, House h)
        {
             Clear();
             WriteLine("Which room do you search?");
             WriteLine("A: Living Room");
             WriteLine("B: Kitchen");
             WriteLine("C: Bedroom");
             WriteLine("D: Bathroom");
             WriteLine("You have " + dog.dogtreats + " dogtreats and " + dog.baddog + " bad dog points.");
            ConsoleKeyInfo roomkey = ReadKey();
            ReadLine();
            if (roomkey.Key == ConsoleKey.A)
            {
                 
                house.LivingRoom(G,f,d,h);
                Clear();
            }
           else if (roomkey.Key == ConsoleKey.B)
            {
                
                house.Kitchen(G,f,d,h);
                Clear();
            }
           else if (roomkey.Key == ConsoleKey.C)
            {
                 
                int sf = house.Bedroom(G, f,d,h);
                if (sf==2)
                {
                    RoomChoice1(G,f,d,h);
                }
                Clear();

            }
           else if (roomkey.Key == ConsoleKey.D)
            {
               
                house.Bathroom(G,f,d,h);
                int next = house.Bedroom(G,f,d,h);
                if (next==1)
                {
                    house.Dresser(G,d,f,h);
                }
                Clear();
            }
            else
            {
                WriteLine("Invalid input");
                RoomChoice1(G,f,d,h);
            }
        }
    }
   
}
