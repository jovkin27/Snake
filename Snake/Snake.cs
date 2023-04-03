using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Snake //умения и свойства змейки
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake(Point tail, int length, Direction _direction) //хвост
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail, ConsoleColor.Red);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        internal void Move() //передвижение по полю
        {
            {
                Point tail = pList.First();
                pList.Remove(tail);
                Point head = GetNextPoint();
                pList.Add(head);
                tail.Clear();
                head.Draw();
            }

        }
        public Point GetNextPoint() //бошка
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head, ConsoleColor.Red);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail() //удар об хвост
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key) //управление
        {
            Parametrs settings = new Parametrs();
            Sounds sound = new Sounds(settings.GetResourceFolder());

            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
                sound.Movement();
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
                sound.Movement();
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
                sound.Movement();
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
                sound.Movement();
            }

        }

        internal bool Eat(Point food) //кушать 
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }    
}
