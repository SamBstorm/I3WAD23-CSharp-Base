namespace Exo_18_MiniJeux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice;
            dice.min = 1;
            dice.max = 6;

            Console.WriteLine(dice.Roll());
            Console.WriteLine(dice.Roll(-2));
            Console.WriteLine(dice.Roll(5));
            Console.WriteLine(dice.Roll());
            Console.WriteLine(dice.Roll(4));
        }
    }
}