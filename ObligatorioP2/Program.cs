using System;
using System.Collections.Generic;
using System.Linq;

namespace ObligatorioP2
{
    class Program
    {
        private static Sistema unS = new Sistema();

        static void Main(string[] args)
        {
            unS.Precarga();
            
            int option;
            do
            {
                listarMenu();
                option = checkIfNumber(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ListarTodasLasActividades();
                        break;
                    case 2:
                        ListarCategorias();
                        break;
                    case 3:
                        ListarLugares();
                        break;
                    case 4:
                        ListarActividadesP();
                        break;
                    case 5:
                        ListarPorCategoria();
                        break;
                    case 6:
                        CambiarAforo();
                        break;
                    case 7:
                        CambiarPrecioPorButaca();
                        break;
                    default:
                        break;
                }

                if (option != 0)
                {
                    Console.WriteLine("Presione cualquier tecla para volver al menú principal");
                    
                }
                Console.ReadKey();
            } while (option != 0);

          
        }

        private static void listarMenu()
        {
            title("Menú");
            string options = "";
            options += "1 - Listar Actividades \n";
            options += "2 - Listar Categorias \n";
            options += "3 - Listar Lugares \n";
            options += "4 - Listar Actividades P\n";
            options += "5 - Listar entre fechas\n";
            options += "6 - Cambiar aforo máximo\n";
            options += "7 - Cambiar precio por butaca\n";

            options += "\n0 - Salir";
            Console.WriteLine(options);

        }
        private static void title(string title)
        {
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
        }
        private static int checkIfNumber(string entrada)
        {
            int option;

            try
            {
                option = int.Parse(entrada);
            }
            catch (Exception)
            {

                Console.WriteLine("No escribió un número valido");
                option = -1;
            }
            return option;
        }

        private static void ListarTodasLasActividades()
        {
            foreach (Actividad unaActividad in unS.Actividades)
            {
                Console.WriteLine(unaActividad);
                Console.WriteLine("------------------------------------------------");
            }
            if (unS.Actividades.Count == 0)
            {
                Console.WriteLine("La lista esta vacia!");
            }
        }
        
        private static void ListarCategorias()
        {
            foreach (Categoria unaCategoria in unS.Categorias)
            {
                Console.WriteLine(unaCategoria);
                Console.WriteLine("------------------------------------------------");
            }
            if (unS.Categorias.Count == 0)
            {
                Console.WriteLine("La lista esta vacia!");
            }
        }

        private static void ListarLugares()
        {
            foreach (Lugar unLugar in unS.Lugares)
            {
                Console.WriteLine(unLugar);
                Console.WriteLine("------------------------------------------------");
            }
            if (unS.Lugares.Count == 0)
            {
                Console.WriteLine("La lista esta vacia!");
            }
        }

        private static void ListarActividadesP()
        {
            List<Actividad> listaActividades = unS.ListarActividadesP();
            foreach (Actividad unaActividad in listaActividades)
            {
                Console.WriteLine(unaActividad);
                Console.WriteLine("------------------------------------------------");
            }
            if (listaActividades.Count == 0)
            {
                Console.WriteLine("La lista esta vacia!");
            }
        }

        private static void ListarPorCategoria()
        {
            Console.WriteLine("Escribe la categoria");
            string categoria = Console.ReadLine();
            Console.WriteLine("Escribe la primera fecha");
            DateTime fecha1 = ArmarFecha();
            Console.WriteLine("Escribe la segunda fecha");
            DateTime fecha2 = ArmarFecha();
            List<Actividad> listaActividades = unS.ListarPorCategoria(categoria, fecha1, fecha2);
            foreach (Actividad unaActividad in listaActividades)
            {
                Console.WriteLine(unaActividad);
                Console.WriteLine("------------------------------------------------");
            }
            if (listaActividades.Count == 0)
            {
                Console.WriteLine("La lista esta vacia!");
            }

        }

        private static DateTime ArmarFecha()
        {
            int anio = -1;
            int mes = -1;
            int dia = -1;
            
                do
                {
                    Console.WriteLine("El año:");
                    anio = checkIfNumber(Console.ReadLine());
                } while (anio < 0);

                do
                {
                    Console.WriteLine("El mes:");
                    mes = checkIfNumber(Console.ReadLine());
                } while (mes < 1 || mes > 12);

                do
                {
                    Console.WriteLine("El día:");
                    dia = checkIfNumber(Console.ReadLine());
                } while (dia < 1 || dia > 31);

            return new DateTime(anio, mes, dia);
        }

        private static void CambiarAforo()
        {
            Console.WriteLine("Escriba el nuevo porcentaje de aforo(entre 0 y 100)");
            int aforo = checkIfNumber(Console.ReadLine());
            if (aforo >= 0 && aforo <= 100)
            {
                Cerrado.CambiarPorcentajeAforo(aforo);
            }
            else
            {
                Console.WriteLine("Valor no valido.");
            }
        }

        private static void CambiarPrecioPorButaca()
        {
            Console.WriteLine("Escriba el nuevo precio de las butacas");
            decimal precio = checkIfNumber(Console.ReadLine());
            if (precio >= 0)
            {
                Abierto.CambiarValorButaca(precio);
            }
            else
            {
                Console.WriteLine("Valor no valido.");
            }
        }
    }
}
