namespace Exo_12_CalculEcrit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? response;
            do
            {
                Console.WriteLine("Veuillez introduire un premier nombre entier ");
                response = Console.ReadLine();
            } while (!int.TryParse(response, out _));

            string nb1 = response;

            do
            {
                Console.WriteLine("Veuillez introduire un second nombre entier ");
                response = Console.ReadLine();
            } while (!int.TryParse(response, out _));

            string nb2 = response;

            while(nb1.Length > nb2.Length)
            {
                nb2 = "0" + nb2;
            }

            while (nb1.Length < nb2.Length)
            {
                nb1 = "0" + nb1;
            }

            char[] nbs1 = nb1.ToCharArray();
            char[] nbs2 = nb2.ToCharArray();


            string result = "";
            int report = 0;
            for (int i = nbs1.Length -1 ; i >= 0; i--)
            {
                int sum = int.Parse(nbs1[i].ToString()) + ((int)nbs2[i] - 48) + report;
                if(sum >= 10)
                {
                    report = sum / 10;
                    sum = sum % 10;
                }
                else
                {
                    report = 0;
                }
                result = sum.ToString() + result;
            }

            if (report != 0) result = report + result;
            Console.WriteLine(result);
        
        }
    }
}