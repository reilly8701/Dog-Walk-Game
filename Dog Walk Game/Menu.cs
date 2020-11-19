using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dog_Walk_Game
{
    class Menu
    {
        private int Chosen;
        private string[] Choices;
        private string Prompt;
         
        public Menu(string prompt, string[] choices)
        {
            Prompt = prompt;
            Choices = choices;
            Chosen = 0;

        }
       private void MenuDisplay()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Choices.Length; i++)
            {
                string currentChoice = Choices[i];
                string front;
             
                if (i==Chosen)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                    front = "!!!";
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                    front = "   ";
                }
                WriteLine($"{front}{currentChoice}{front}");
            }
            ResetColor();
        
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                MenuDisplay();
                ConsoleKeyInfo keyinfo = ReadKey(true);
                keyPressed = keyinfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    Chosen--;
                    if (Chosen == -1) 
                    {
                        Chosen = Choices.Length-1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    Chosen++;
                    if (Chosen==Choices.Length)
                    {
                        Chosen = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return Chosen;
        }
    }   
        
    
}
