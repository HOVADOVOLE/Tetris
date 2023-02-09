using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Position
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Position(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }
    }
}
