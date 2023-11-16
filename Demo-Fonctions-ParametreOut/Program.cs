namespace Demo_Fonctions_ParametreOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematique m = new Mathematique();

            double modulo;
            int quotient;
            double result = m.CompleteDivisionResult(64.2, 5, out modulo, out quotient);

            Console.WriteLine($"La division de 64.2 par 5 donne\nUne division entière de {quotient} avec un reste de {modulo},\nsoit en décimal {result}!");

            int[] cotes = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Console.WriteLine($"La moyenne est de {m.Moyenne(cotes)}.");

            double[] cotes2 = { 1, 2, 3.14, 4.2, 5, 6, 7, 8.5, 9.1, 10, 11 };
            Console.WriteLine($"La moyenne est de {m.Moyenne(cotes2)}.");
        }
    }
}