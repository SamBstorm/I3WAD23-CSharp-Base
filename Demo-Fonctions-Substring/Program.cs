namespace Demo_Fonctions_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer votre e-mail :");
            string email = Console.ReadLine();

            Console.WriteLine($"Votre email est : {email}");

            string first_char = email.Substring(0, 1);
            Console.WriteLine($"La première lettre est : {first_char}");

            string three_chars_from_third = email.Substring(2, 3);
            Console.WriteLine($"Les trois caractères qui se suivent à partir du troisième de l'email sont '{three_chars_from_third}'.");

            string five_last_chars = email.Substring(email.Length - 5, 5);
            Console.WriteLine($"Les cinq derniers caractères de votre emails sont '{five_last_chars}'");
        }
    }
}