namespace Demo_Fonctions_ToCharArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insérez un texte :");

            string texte = Console.ReadLine() ?? "";

            char[] texte_array = texte.ToCharArray();

            int[] nbs = new int[texte_array.Length];
            for (int i = 0; i < nbs.Length; i++)
            {
                char c = texte_array[i];
                //Console.WriteLine((int)c - 48);
                nbs[i] = int.Parse(c.ToString());
            }

            foreach (int nb in nbs)
            {
                Console.WriteLine(nb);
            }
        }
    }
}