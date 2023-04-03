using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Score //Очки
    {
        private int score;
        public Score(int score)
        {
            this.score = score;
        }
        public int ScoreUp()
        {
            score += 1;
            return score - 1;
        }
        public void ScoreWrite(int wide, int lenght)
        {
            Console.SetCursorPosition(wide, lenght);
            Console.WriteLine("Score:" + score.ToString());
        }
    }
}
