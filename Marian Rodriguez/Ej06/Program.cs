using Microsoft.Win32;

namespace Ej06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  6. (CONDICIONALES)
            //Una empresa que se dedica a la comercialización de lámparas de bajo consumo, registra de sus
            //ventas, los siguientes datos: marca y cantidad.El precio de cada lamparita es de
            //$150(Sin importar la marca).
            //El programa deberá calcular el precio total de la venta, aplicando un descuento si es
            //que corresponde.
            //A.Si compra 6 lamparitas o más, tiene un descuento del 50 %.

            //B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40 % y si es de otra marca,
            //el descuento es del 30 %.

            //C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25 %,
            //y si es de otra marca el descuento es del 20 %.

            //D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15 %, si es “FelipeLamparas
            //se hace un descuento del 10 % y si es otra marca, 5 %.

            //E.Si el importe final con descuento suma más de $950, se debe agregar el 10 % de ingresos brutos.

            //Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento,
            //y si corresponde total de ingresos brutos y total a pagar.

            string marca;
            int cantidadLamparitas;
            double precioLamparitaUnidad;
            double precioSinDescuento;
            double precioTotalVenta;
            double precioConDescuento;
           
            double descuento50;
            double descuento40;
            double precioDesc50;
            double precioDesc40;

            precioLamparitaUnidad = 150;
            
           
            descuento50 = 0.50;
            descuento40 = 0.40;

            Console.WriteLine("Por favor ingrese la marca: ArgentinaLuz,FelipeLamparas, otra marca.  ");
            marca = Console.ReadLine();

            Console.WriteLine("Por favor ingrese cantidad de lamparitas: ");
            cantidadLamparitas = Convert.ToInt32 (Console.ReadLine());

         



            //if (cantidadLamparitas >= 6)
            //{

            //    precioSinDescuento = cantidadLamparitas* precioLamparitaUnidad;


            //    precioDesc50 = precioSinDescuento * descuento50;

            //    precioTotalVenta = precioDesc50;

            //    Console.WriteLine($"El precio con el descuento es de: $ {precioTotalVenta}");



            //} 
            //else
                
            //{

            //    Console.WriteLine($"El precio con el descuento es de: $ {cantidadLamparitas}");
            //}
        }

 
        }
    }
}
