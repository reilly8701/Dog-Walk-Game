using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
/*/"Game developed by Maura Reilly
Uses assets from:
Programming is Fun Adventure Game tutorials
Professor Mike Hadley's keyboard controlled menu
while key referenced from Microsoft
and made with some tutoring assistance from Ishan Dutta, Brendan Lienau, Rafael Santana, and Janel
Title asset from http://patorjk.com/software/taag/#p=moreopts&f=ANSI%20Shadow&t=Dog%20Walk!!
AASCII dog by unknown artist from https://www.asciiart.eu/animals/dogs
/*/

namespace Dog_Walk_Game
{
    class Program
    {
      public static void Main(string[] args)
        {
          
                game g = new game();
             g.MainMenu(g, g.Fun, g.dog, g.house); 
             g.StartGame(g, g.Fun, g.dog, g.house);

        }


}
}
