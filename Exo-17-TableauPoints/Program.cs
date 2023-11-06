namespace Exo_17_TableauPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 5;
            Point?[,] tab = new Point?[TAILLE,TAILLE];

            Point p;

            for (int i = 0; i < TAILLE; i++)
            {
                p.x = i + 1;
                p.y = i + 1;

                tab[i, i] = p;
            }

            for (int row = 0; row < TAILLE; row++)
            {
                for (int col = 0; col < TAILLE; col++)
                {
                    if (tab[row,col] is null) Console.Write("\t");
                    //else Console.Write($"X : {tab[row,col]?.x} - Y : {tab[row,col]?.y}");
                    else
                    {
                        p = (Point)tab[row, col];
                        Console.Write($"X : {p.x} - Y : {p.y}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}