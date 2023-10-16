namespace Demo_Boucles_WhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo While
            //Console.WriteLine("Veuillez entrer un chiffre :");
            //string reponse = Console.ReadLine();
            //int nb;
            //bool isConverted = int.TryParse(reponse, out nb);
            //while (!isConverted)
            //{
            //    Console.WriteLine($"Erreur! Le nombre {reponse} n'est pas valide!\nVeuillez entrer un chiffre :");
            //    reponse = Console.ReadLine();
            //    isConverted = int.TryParse(reponse, out nb);
            //}
            //Console.WriteLine($"Le nombre {nb} est correct!");

            #endregion

            #region Demo Do While

            //int nb;
            //bool isConverted;
            //string message = "Veuillez entrer un chiffre :";
            //do
            //{
            //    Console.WriteLine(message);
            //    string reponse = Console.ReadLine();
            //    message = $"Erreur! Le nombre {reponse} n'est pas valide!\nVeuillez entrer un chiffre :";
            //    isConverted = int.TryParse(reponse, out nb); 
            //} while (!isConverted);
            //Console.WriteLine($"Le nombre {nb} est correct!");

            #endregion

            #region Demo Do While (simplifié)

            int nb;
            do
            {
                Console.WriteLine("Veuillez entrer un chiffre :");
            } while (!int.TryParse(Console.ReadLine(), out nb));
            Console.WriteLine($"Le nombre {nb} est correct!");

            #endregion
        }
    }
}