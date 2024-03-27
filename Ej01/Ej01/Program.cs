namespace Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string edad;
            int edadNumerica;

            Console.WriteLine("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su edad: ");
            edad = Console.ReadLine();

            edadNumerica = int.Parse(edad); 
           
            Console.WriteLine($"Muchas gracias {nombre} {apellido}, su edad es {edadNumerica}");


        }
    }
}
