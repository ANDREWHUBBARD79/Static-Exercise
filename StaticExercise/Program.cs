using System.Net.WebSockets;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        { 


            var celcius = TempConverter.CelciusToFahrenheit(68);//20
            var fahrenheit = TempConverter.FahrenheitToCelcius(68);//68
            
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
