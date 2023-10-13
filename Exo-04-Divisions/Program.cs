namespace Exo_04_Divisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un premier nombre entier : ");
            string reponse = Console.ReadLine();
            if(int.TryParse(reponse, out int nombre1)) {
                Console.WriteLine("Veuillez introduire un second nombre entier : ");
                reponse = Console.ReadLine();
                if(int.TryParse(reponse, out int nombre2))
                {
                    int result_div_ent = nombre1 / nombre2;
                    int result_modulo = nombre1 % nombre2;
                    float result_div = (float)nombre1 / nombre2;
                    Console.WriteLine(
@$"Avec les nombres {nombre1} et {nombre2} nous obtenons :
Division entière : {result_div_ent}
Modulo : {result_modulo}
Division avec décimal : {result_div}");
                }
                else { Console.WriteLine($"Le nombre '{reponse}' n'est pas un nombre entier!"); }
            }
            else { Console.WriteLine($"Le nombre '{reponse}' n'est pas un nombre entier!"); }
        }
    }
}