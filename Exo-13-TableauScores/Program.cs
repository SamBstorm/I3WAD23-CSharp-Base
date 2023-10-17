namespace Exo_13_TableauScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Version Tableau
            //const int MIN = 2;
            //const int MAX = 10;

            //int[] scores = new int[MAX];

            //int nb_joueurs;
            //do
            //{
            //    Console.WriteLine($"Pour cette partie, combien de joueurs ont participé (entre {MIN} et {MAX}) :"); 
            //} while (!int.TryParse(Console.ReadLine(), out nb_joueurs) || nb_joueurs < MIN || nb_joueurs > MAX);

            //for (int i = 0; i < nb_joueurs; i++)
            //{
            //    string? response;
            //    do
            //    {
            //        Console.Write($"Entrez le score du joueur {i + 1} : ");
            //        response = Console.ReadLine();
            //    } while (!int.TryParse(response, out scores[i]));
            //}

            //int total = 0;
            //for (int i = 0;i < nb_joueurs;i++)
            //{
            //    total += scores[i];
            //}

            //Console.WriteLine($"La moyenne des scores est {(double)total/nb_joueurs}."); 
            #endregion
            #region BONUS avec List<T>
            const int MIN = 2;
            const int MAX = 10;

            List<int> scores = new List<int>();

            int nb_joueurs;
            do
            {
                Console.WriteLine($"Pour cette partie, combien de joueurs ont participé (entre {MIN} et {MAX}) :");
            } while (!int.TryParse(Console.ReadLine(), out nb_joueurs) || nb_joueurs < MIN || nb_joueurs > MAX);

            for (int i = 0; i < nb_joueurs; i++)
            {
                string? response;
                int score;
                do
                {
                    Console.Write($"Entrez le score du joueur {i + 1} : ");
                    response = Console.ReadLine();
                } while (!int.TryParse(response, out score));
                scores.Add(score);
            }

            int total = 0;
            foreach(int score in scores)
            {
                total += score;
            }

            Console.WriteLine($"La moyenne des scores est {(double)total / nb_joueurs}.");
            #endregion
        }
    }
}