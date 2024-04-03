namespace StringEj03
{
    internal class Program
    {
        static void Main(string[] args)
        {




            ////3. Pedir el ingreso de una palabra y reemplazar todas las letras A 
            /// por un carácter especial (* , & , etc).
            ///ej: Manzana->M * nz * n *.




            String palabra;

            Console.Write("Escriba una palabra");
            palabra = Console.ReadLine();

            char[] letras = palabra.ToCharArray();

            for (int i = 0; i< letras.Length; i++) 
            {
                if (letras[i] == 'a ') 


            }

        }
    }
}
