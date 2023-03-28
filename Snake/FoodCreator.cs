using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator //еда и её появление 
    {
        private int mapWidth;
        private int mapHeight;
        private char sym;
        ConsoleColor color;
        Random random = new Random();
        public FoodCreator(int mapWidth, int mapHeight, char sym, ConsoleColor color_)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
            color = color_;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym, color);
        }
    }
}
