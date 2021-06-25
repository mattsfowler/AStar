using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class AStar
    {
        private bool[,] board;
        private BoardGraphics graphics;

        public AStar(BoardGraphics graphics = null)
        {
            this.graphics = graphics;
        }

        public bool SetBoard(bool[,] board)
        {
            this.board = board;
            return true;
        }

        public List<Point> FindPath(Point start, Point finish)
        {
            PriorityQueue<Point> open = new PriorityQueue<Point>();
            open.enqueue(start, 0);

            while (open.Count() > 0)
            {
                Point current = open.dequeue();

            }

            List<Point> finalPath = new List<Point>();
            return finalPath;
        }
    }
}
