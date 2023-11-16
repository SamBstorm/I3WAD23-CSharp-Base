namespace Exo_21_Cartes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte[] paquet = new Carte[52];

            //int couleur_nb = 0;
            //int valeur_nb = 2;

            #region NE FONCTIONNE PAS (PIÈGE DU FOREACH)
            //foreach (Carte carte in paquet)
            //{
            //    carte.couleur = (Couleurs)couleur_nb % 4;
            //    carte.valeur = (Valeurs)valeur_nb % 13;
            //} 
            #endregion

            int index = 0;
            foreach (Couleurs couleur_carte in Enum.GetValues<Couleurs>())
            {
                foreach (Valeurs valeur_carte in Enum.GetValues<Valeurs>())
                {
                    paquet[index].couleur = couleur_carte;
                    paquet[index].valeur = valeur_carte;
                    index++;
                }
            }

            foreach (Carte carte in paquet)
            {
                Console.WriteLine($"{carte.valeur} de {carte.couleur}");
            }
        }
    }
}