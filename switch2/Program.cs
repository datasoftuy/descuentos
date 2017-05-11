using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        
        
        // pedir un precio y una categoria segun la categoria el precio recibira un aumewnto o descuento
        //CatA 10 CatB 20  CatC 10  

        // CatD 15% aumento si el precio es menor a 600 y sino 20%




            float precio;
            double descuento,preciofinal;
            string categoria;
            Console.WriteLine("Ingrese un precio");
            precio = Convert.ToInt64(Console.ReadLine());


            Console.WriteLine("Ingrese la categoria");
            
            categoria = Console.ReadLine().ToUpper();


            switch (categoria)


            {

                 case "A":


                        descuento = precio * 0.10;
                        preciofinal = precio - descuento;
                        Console.WriteLine("El precio final es: " + preciofinal);
                        Console.ReadKey();

                        break;


                case "B":

                        descuento = precio * 0.20;
                        preciofinal = precio - descuento;
                        Console.WriteLine("El precio final es: " + preciofinal);
                        

                        break;

                 default: Console.Write("Categoria incorrecta");
                        Console.ReadKey();
                break;





                
            
            
            
            
            
            }



        
        }
    }
}
