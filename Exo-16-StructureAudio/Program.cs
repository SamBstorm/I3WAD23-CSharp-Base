namespace Exo_16_StructureAudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PisteAudio piste1;
            piste1.artiste = "Stromae";
            piste1.titre = "Tous les mêmes";
            piste1.categorie = "Pop";
            piste1.tempsSeconde = 127;

            PisteAudio piste2 = piste1;
            piste2.titre = "Formidable";
            piste2.tempsSeconde = 184;


            Album album1;
            album1.titre = "Novembre";
            album1.dateSortie = new DateOnly(2023, 11, 6);
            album1.pistes = new List<PisteAudio>();
            album1.pistes.Add(piste1);
            album1.pistes.Add(piste2);

            Console.WriteLine($"Album 1 : {album1.titre} sorti le {album1.dateSortie} :");
            Console.WriteLine($"{album1.pistes.Count} pistes");
            foreach (PisteAudio piste in album1.pistes)
            {
                Console.WriteLine($"\t\"{piste.titre}\" - chanté par {piste.artiste} ({piste.tempsSeconde} sec.)");
            }
        }
    }
}