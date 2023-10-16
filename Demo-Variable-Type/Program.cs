namespace Demo_Variable_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOMBRES ENTIER :");
            Console.WriteLine("----------------");
            Console.WriteLine();
            int nb = Int32.MaxValue;
            Console.WriteLine($"La valeur maximale d'un entier est : {nb} ({nb.ToString().Length} chiffres)");
            nb = Int32.MinValue;
            Console.WriteLine($"La valeur minimale d'un entier est : {nb}");

            long nb_grand = Int64.MaxValue;
            Console.WriteLine($"La valeur maximale d'un long est : {nb_grand} ({nb_grand.ToString().Length} chiffres)");
            nb_grand = Int64.MinValue;
            Console.WriteLine($"La valeur minimale d'un long est : {nb_grand}");

            short nb_petit = Int16.MaxValue;
            Console.WriteLine($"La valeur maximale d'un short est : {nb_petit} ({nb_petit.ToString().Length} chiffres)");
            nb_petit = Int16.MinValue;
            Console.WriteLine($"La valeur minimale d'un short est : {nb_petit}");

            Console.WriteLine();
            Console.WriteLine("NOMBRES ENTIER NON-SIGNÉS:");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            uint unb = UInt32.MaxValue;
            Console.WriteLine($"La valeur maximale d'un entier non-signé est : {unb} ({unb.ToString().Length} chiffres)");
            unb = UInt32.MinValue;
            Console.WriteLine($"La valeur minimale d'un entier non-signé est : {unb}");

            ulong unb_grand = UInt64.MaxValue;
            Console.WriteLine($"La valeur maximale d'un long non-signé est : {unb_grand} ({unb_grand.ToString().Length} chiffres)");
            unb_grand = UInt64.MinValue;
            Console.WriteLine($"La valeur minimale d'un long non-signé est : {unb_grand}");

            ushort unb_petit = UInt16.MaxValue;
            Console.WriteLine($"La valeur maximale d'un short non-signé est : {unb_petit} ({unb_petit.ToString().Length} chiffres)");
            unb_petit = UInt16.MinValue;
            Console.WriteLine($"La valeur minimale d'un short non-signé est : {unb_petit}");

            Console.WriteLine();
            Console.WriteLine("NOMBRES RÉELS :");
            Console.WriteLine("---------------");
            Console.WriteLine();

            decimal deci = Decimal.MaxValue;
            Console.WriteLine($"La valeur maximale d'un nombre entier déguisé en décimal est : {deci} ({deci.ToString().Length} chiffres)");
            deci = Decimal.MinValue;
            Console.WriteLine($"La valeur minimale d'un nombre entier déguisé en decimal est : {deci}");

            float reel_petit = Single.MaxValue;
            Console.WriteLine($"La valeur maximale d'un décimal de petite précision est : {reel_petit}");
            reel_petit = Single.MinValue;
            Console.WriteLine($"La valeur minimale d'un décimal de petite précision est : {reel_petit}");

            double reel_grand = Double.MaxValue;
            Console.WriteLine($"La valeur maximale d'un décimal de grande précision est : {reel_grand}");
            reel_grand = Double.MinValue;
            Console.WriteLine($"La valeur minimale d'un décimal de grande précision est : {reel_grand}");

            Console.WriteLine();
            Console.WriteLine("AUTRES TYPES:");
            Console.WriteLine("-------------");
            Console.WriteLine();

            char caractere = 'a';
            Console.WriteLine($"Une variable char, contrairement au String, permet de stocker un seul et unique caractère!");
            caractere = (char)97;
            Console.WriteLine($"Voici le contenu de mon caractère :{caractere}");

            bool isOk = false;
            Console.WriteLine($"Une variable bool, ne connait que 2 valeurs : {isOk}");
            isOk = true;
            Console.WriteLine(isOk);
        }
    }
}