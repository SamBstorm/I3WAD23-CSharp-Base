namespace Demo_Collections_Dictionnaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,bool> presences = new Dictionary<string,bool>();

            string[] names = {
                "Elena",
                "Najoua",
                "Emanuela",
                "Hanane",
                "Hélène",
                "Dorine",
                "Laurence",
                "Margot",
                "Senem",
                "Vitoria",
                "Hsin-i",
                "Yusrâ"
            };

            for (int i = 0; i < names.Length; i++) {
                presences.Add(names[i], false);
            }

            Console.WriteLine("Veuillez noter la présence pour chaque élève :");

            foreach (KeyValuePair<string, bool> kvp in presences)
            {
                string reponse;
                do
                {
                    Console.Write($"{kvp.Key} : (P)résent ou (A)bsent ?");
                    reponse = Console.ReadLine();
                    Console.WriteLine();
                } while (reponse != "A" && reponse != "P");
                presences[kvp.Key] = reponse == "P";
            }

            Console.Clear();
            Console.WriteLine("Les absents sont :");

            foreach (KeyValuePair<string, bool> kvp in presences)
            {
                if(!kvp.Value) Console.WriteLine(kvp.Key);
            }
        }
    }
}