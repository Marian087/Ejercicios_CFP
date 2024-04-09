namespace FuncionesExplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ///que no reciben nada y no retorna nada.
            ///nO SON RECOMENDADAS

            //saludar(); // invocaciòn de la funciòn.

            //static  void saludar()

            //Console.Write("Ingrese su nombre: ");
            //Console.WriteLine($"Bienvenido: ¨{Console.ReadLine()}");

            /// CREAR UNA FUNCION QUE PIDA EL INGRESO DE UN NUMERO ENTERO 
            /// QUE CON UN RANGO MAXIMO Y UN RANGO MINIMO Y LO RETORNE

            static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo);
            {

                int numeroValido = 0;

                Console.Write(mensaje);
                numeroValido = int.Parse(Console.ReadLine());

                while(numeroValido < minimo ||  numeroValido> maximo)

                {
                    Console.WriteLine(mensajeError);
                    Console.Write(mensaje);

                    numeroValido = int.Parse(Console.ReadLine());

                }
                return numeroValido;

                                
            }
            static bool EsNumerico(string dato)
            {
                bool EsNumerico = true;

                foreach (char digito in dato)
                {
                    if (!char.IsDigit(digito))
                    {

                        EsNumerico = false;
                        break;

                    }


                    
            
            }

        }
    }
}
