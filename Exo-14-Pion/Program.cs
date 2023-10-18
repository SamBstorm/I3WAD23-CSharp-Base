using System.Text;

namespace Exo_14_Pion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enoncé
             */
            Console.OutputEncoding = Encoding.Unicode;
            /*1. Génération du Tableau*/
            const int TAILLE = 11;
            bool[] tableau = new bool[TAILLE];

            /*2. Définir la position du PION*/
            int position = TAILLE / 2;
            tableau[position] = true;

            string choix;
            do
            {
                /*3. Afficher le tableau + instructions*/
                /* [     😉     ]*/
                const string PION = "😉";
                const string VIDE = " ";
                Console.Clear();
                Console.Write("[");
                foreach (bool cell in tableau)
                {
                    if (cell)
                    {
                        Console.Write(PION);
                    }
                    else
                    {
                        Console.Write(VIDE);
                    }
                }
                Console.WriteLine("]");
                Console.WriteLine(
    @"Faites un choix:
'G' pour déplacer le pion sur la gauche
'D' pour déplacer le pion sur la droite
'Q' pour stopper l'application");

                /*4. Attendre le choix de l'utilisateur*/
                do
                {
                    choix = Console.ReadKey().Key.ToString();
                } while (choix != "G" && choix != "D" && choix != "Q");

                /*5. a. Si choix "G":
                        Déplacer le pion ==> retour 3.
                       b. Si choix "D":
                        Déplacer le pion ==> retour 3.
                */
                tableau[position] = false;
                switch (choix) {
                    case "G":
                        if(position > 0) position--;
                        break;
                    case "D":
                        if(position < tableau.Length-1) position++;
                        break;
                }
                tableau[position] = true;

                /* c. Si choix "Q": Tout arrêter*/ 
            } while (choix != "Q");

        }
    }
}