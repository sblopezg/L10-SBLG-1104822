using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_SBLG_1104822
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int contador = 0;
            string usuario;
            string contraseña;
            bool res = false;


            while (cantidad < 3)
            {
                Console.WriteLine("Ingrese el usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Coloque contraseña");
                contraseña = Console.ReadLine();

                res = login(usuario, contraseña);
                if (res == true)
                {
                    cantidad = 3;
                    Console.WriteLine("Ingreso accedido");
                }
                else
                {
                    Console.WriteLine("Error al ingresar, ingrese de nuevo, cantidad de intentos: " + contador);
                    contador++;
                    cantidad++;
                }
                if (contador == 3)
                {
                    Console.WriteLine("Se han agotado las oportunidades");
                }

            }

            Console.ReadKey();
        }
        public static bool login(string usuario, string contra)
        {
            if (usuario == "usuario1" && contra == "asdasd")
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
