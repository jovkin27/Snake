using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Score
    {
        private int score;
        protected List<int> sList;
        public Score(int score)
        {
            this.score = score;
        }
        public void ScoreUp()
        {
            score += 1;
            sList.Add(score);
        }
        public void ScoreWrite()
        {
            Console.SetCursorPosition(90, 10);
            Console.WriteLine("Score:" + score.ToString());
        }
    }
}
