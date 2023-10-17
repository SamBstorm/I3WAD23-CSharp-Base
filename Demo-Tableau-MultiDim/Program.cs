namespace Demo_Tableau_MultiDim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 4;
            const int ROWS = 12;

            bool[,] grid = new bool[COLS, ROWS];

            grid[1, 1] = true;
            grid[3, 8] = true;

            for (int row_i = 0; row_i < ROWS; row_i++)
            {
                for (int col_i = 0; col_i < COLS; col_i++)
                {
                    Console.Write($"[{((grid[col_i, row_i]) ? "X" : " ")}]");
                }
                Console.WriteLine();
            }
        }
    }
}