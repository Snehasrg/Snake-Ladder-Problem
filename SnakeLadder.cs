using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class SnakeLadder
    {
        public static void GameStart()
        {
            int position = 0;
            int player1;

            player1 = position;
            Console.WriteLine("Player 1 position is " + player1);

            Random random = new Random();
            int dice = random.Next(6);
            Console.WriteLine("Player 1 roll die and get position " + dice);
        }
    }
}
