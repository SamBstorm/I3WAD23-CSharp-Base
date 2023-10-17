namespace Demo_Fonctions_ToCharArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insérez un texte :");

            string texte = Console.ReadLine() ?? "";

            char[] texte_array = texte.ToCharArray();

            foreach (char c in texte_array)
            {
                //Console.WriteLine((int)c - 48);
                Console.WriteLine(int.Parse(c.ToString()));
            }
        }
    }
}