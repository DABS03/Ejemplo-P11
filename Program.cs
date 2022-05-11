using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Clase_miercoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader leyendo = File.OpenText(@"C:\Users\dabur\source\repos\Perfil.txt");
            //Variables
            string linea, nombre;
            bool yaesta = false;

            //Arreglo
            string[] datos = new string[5];

            Console.WriteLine("Ingrese el nombre que desea buscar");
            nombre = Console.ReadLine();


            linea = leyendo.ReadLine();

            while (linea!=null && yaesta==false)
            {

                //División de los datos por comas (,)
                datos = linea.Split(',');

                if (nombre == datos[0])
                {
                    Console.WriteLine($"Nombre: {datos[0]}");
                    Console.WriteLine($"Ciudad: {datos[1]}");
                    Console.WriteLine($"Telefono: {datos[2]}");
                    Console.WriteLine($"Telefono: {datos[3]}");
                    yaesta = true;
                }
                //Volver a leer si esque la lectura fue falsa
                linea = leyendo.ReadLine();

            }

            if (yaesta == false)
            {
                Console.WriteLine("El nombre que esta buscando no se encontró");
            }
            //Aqui se cierra el archivo de texto
            leyendo.Close();

            Console.ReadLine();

        }
    }
}
