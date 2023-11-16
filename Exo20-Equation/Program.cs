namespace Exo_20_Equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqSecondDegree equation;
            equation.A = 4;
            equation.B = 4;
            equation.C = 1;

            double? x1, x2;

            Console.WriteLine($"({equation.A}X²) + ({equation.B}X) + ({equation.C})");

            if (equation.Resoudre(out x1, out x2))
            {
                Console.WriteLine("Il y a une solution :");
                if (x1 == x2) Console.WriteLine($"La seule valeur de X est {x1}.");
                else Console.WriteLine($"X peut être à la fois {x1} ou {x2}");
            }
            else
            {
                Console.WriteLine("Aucune solution...");
            }
        }
    }
}