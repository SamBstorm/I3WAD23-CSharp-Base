namespace Demo_Fonctions_CelsiusFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius temp1 = new Celsius();
            temp1.temperature = 10;

            Fahrenheit temp2 = temp1.ToFahrenheit();

            Console.WriteLine($"{temp1.temperature} celsius vaut {temp2.temperature} fahrenheit!");

            temp1 = temp2.ToCelsius();
            Console.WriteLine($"{temp2.temperature} fahrenheit vaut {temp1.temperature} celsius!");
        }
    }
}