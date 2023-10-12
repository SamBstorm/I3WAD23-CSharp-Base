namespace Exo_01_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Veuillez entrer un premier nombre entier :");
            //int nombre1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Veuillez entrer un second nombre entier :");
            //int nombre2 = int.Parse(Console.ReadLine());
            //int somme = nombre1 + nombre2;
            //Console.WriteLine("La somme des 2 nombres est : " + somme);

            //En une ligne : Pas à refaire!!!
            //Console.WriteLine("Le résultat est : " + (int.Parse(Console.ReadLine())+ int.Parse(Console.ReadLine()))) ;


            int nombre1, nombre2;
            Console.WriteLine("Veuillez entrer un premier nombre entier :");
            string temp = Console.ReadLine();
            bool isConverted = int.TryParse(temp, out nombre1);
            Console.WriteLine("Veuillez entrer un second nombre entier :");
            temp = Console.ReadLine();
            isConverted = int.TryParse(temp, out nombre2);
            int somme = nombre1 + nombre2;
            Console.WriteLine($"La somme des 2 nombres est : {somme}" );

        }
    }
}