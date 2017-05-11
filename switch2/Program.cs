using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {




            bool salir = false;
            string otravez;
            while (salir != true)
            {


                // pedir un precio y una categoria segun la categoria el precio recibira un aumewnto o descuento
                //CatA 10 CatB 20  CatC 10  

                // CatD 15% aumento si el precio es menor a 600 y sino 20%



                Console.Clear();
                float precio;
                double descuento, preciofinal, impuesto;
                string categoria;
                Console.WriteLine("Ingrese un precio");
                precio = Convert.ToInt64(Console.ReadLine());


                Console.WriteLine("Ingrese la categoria");

                categoria = Console.ReadLine().ToUpper();


                switch (categoria)
                {

                    case "A":

                    case "C":
                        descuento = precio * 0.10;
                        preciofinal = precio - descuento;
                        Console.WriteLine("El precio final es: " + preciofinal);
                        Console.ReadLine();
                        break;

                    case "B":

                        descuento = precio * 0.20;
                        preciofinal = precio - descuento;
                        Console.WriteLine("El precio final es: " + preciofinal);
                        Console.ReadLine();


                        break;

                    case "D":

                        if (precio < 600)
                        {

                            impuesto = precio * 0.15;

                            preciofinal = precio + impuesto;

                            Console.WriteLine("El precio final es: " + preciofinal);

                        }


                        else
                        {

                            impuesto = precio * 0.20;

                            preciofinal = precio + impuesto;

                            Console.WriteLine("El precio final es: " + preciofinal);


                        }

                        Console.ReadLine();


                        break;

                    default: Console.Write("Categoria incorrecta");
                        Console.ReadLine();
                        break;











                }






                Console.WriteLine("Desea calcular otro precio s/n");
                otravez = Console.ReadLine().ToLower();
                if (otravez == "n")
                {
                    salir = true;
                }
            }









        }
    }
}