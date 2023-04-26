using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamado
{
    public class Suporte
    {

        public static void Menu() 
        {
            Console.WriteLine("Pronto Para iniciar o chamado? Se sim digite 's' para continuar!");
            //Console.WriteLine(" ");
            string? Inicio = Console.ReadLine();
            if(Inicio == "s")
            {
                Console.WriteLine("Pediremos as seguintes informações");
                Console.WriteLine(" ");
                Console.WriteLine("1-)Empresa Solicitante");
                Console.WriteLine("2-)Nome do funcionário");
                Console.WriteLine("3-)Departamento");
                Console.WriteLine("4-)Descricao do Chamado");
                Console.WriteLine(" ");

            }
            else
            {
                //Retorno();
            }
        }



    }
}
