namespace Exo_06_IBAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un numéro BBAN à vérifier :");
            string? bban = Console.ReadLine()?.Trim().Replace(" ", "");
            if (!(bban is null) && bban.Length == 12 && long.TryParse(bban, out _))
            {
                string ten_first = bban.Substring(0, 10);
                long ten_digit = long.Parse(ten_first);
                string two_last = bban.Substring(10);
                short two_digit = short.Parse(two_last);
                short modulo = (short)(ten_digit % 97);
                if (modulo == two_digit || (modulo == 0 && two_digit == 97))
                {
                    Console.WriteLine("OK");
                    string code = $"{two_last}{two_last}111400";
                    long code_digit = long.Parse(code);
                    short unknow_two_digit = (short)(98 - (code_digit % 97));
                    Console.WriteLine($"Votre IBAN est : BE{((unknow_two_digit<10)?"0":"")}{unknow_two_digit}{bban}");
                }
                else
                {
                    Console.WriteLine("KO");
                }
            }
            else
            {
                Console.WriteLine($"La valeur '{bban}' n'est pas valide.\nUn BBAN est constitué de 12 chiffres.");
            }
        }
    }
}