namespace Exo_19_GooseGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GooseGame game = new GooseGame();
            game.lastSquare = 63;
            game.Play();
        }
    }
}