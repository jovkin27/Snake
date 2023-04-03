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

        public Walls(int ymap)
        {
            wallList = new List<Figure>();

            HorizontalLIne upline = new HorizontalLIne(0, ymap - 1, 0, '+');
            HorizontalLIne downline = new HorizontalLIne(0, ymap - 1, 25, '+');
            VerticalLine leftline = new VerticalLine(1, 25, 0, '+');
            VerticalLine rightline = new VerticalLine(1, 25, ymap - 1, '+');

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
