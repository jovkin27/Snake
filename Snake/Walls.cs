using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls //Границы игрового поля 
    {
        List<Figure> wallList;

        public Walls( int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLIne upline = new HorizontalLIne(0, mapWidth - 2, 0, '+');
            HorizontalLIne downline = new HorizontalLIne(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftline = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightline = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);

        }

        internal bool Ishit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }   

        public void Draw()
        {
            foreach ( var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
