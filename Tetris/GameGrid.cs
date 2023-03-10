namespace Tetris
{
    public class GameGrid
    {
        readonly int[,] grid;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[columns, rows];
        }

        public bool IsInside(int r, int c)
        {
            return r >= 0 && r < Rows && c >= 0 && c < Columns;
        }

        public bool IsEmpty(int r, int c)
        {
            return IsInside(r, c) && grid[r, c] == 0;
        }
        public bool IsRowFull(int r)
        {
            for (int i = 0; i < Columns; i++)
            {
                if (grid[r, i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsRowEmpty(int r)
        {
            for (int i = 0; i < Columns; i++)
            {
                if (grid[r, i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void ClearRow(int r)
        {
            for (int i = 0; i < Columns; i++)
            {
                grid[r, i] = 0;
            }
        }
        public void MoveRowDown(int r, int numRows)
        {
            for (int i = 0; i < Columns; i++)
            {
                grid[r + numRows, i] = grid[r, i];
                grid[r, i] = 0;
            }
        }
        public int ClearFullRows()
        {
            int cleared = 0;
            for (int i = Rows - 1; i > 0; i--)
            {
                if (IsRowFull(i))
                {
                    ClearRow(i);
                    cleared++;
                }
                else if(cleared > 0)
                {
                    MoveRowDown(i, cleared);
                }
            }
            return cleared;
        }
    }
}
