using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamados
{
    public class Painel
    {

        public int Id { get; set; }
        public static void Menu()
        {
            Console.WriteLine("           ||||------------------------------------------------------------------------------||||     ");
            Console.WriteLine("           ||||--------------------------SISTEMA DE CHAMADOS UCASE---------------------------||||     ");
            Console.WriteLine("           ||||------------------------------------------------------------------------------||||     ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Pronto Para Usar o sistema? Se sim digite 's' para continuar! caso não, digite 'n' para fechar.");
            //Console.WriteLine(" ");
            string? Inicio = Console.ReadLine();
            if (Inicio == "s")
            {

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();

                Console.WriteLine("Abaixo serão listadas as acões disponíveis no sistema.");
                Console.WriteLine(" ");
                Console.WriteLine("Ações disponíveis:");
                Console.WriteLine("1-) Iniciar Chamado");
                Console.WriteLine("2-) Listar Chamados");
                Console.WriteLine("3-) Remover Chamados");
                Console.WriteLine("4-) Sair do Sistema");
                Console.Write("Escolha a acão desejada digitando o numero correspondente - exemplo = -:3  ------:");

                string? opcao = Console.ReadLine();

                Chamado chamado = new Chamado();
                switch (opcao)
                {
                    case "1": chamado.Gravar(); break;
                    case "2": chamado.Listar(); break;
                    case "3": chamado.Remover(); break;
                    case "4": Sair();break;
                    default: Retorno();break;

                }

            }
            else if(Inicio == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Retorno();
            }
        }

        public static void Retorno() 
        {
            Console.Clear();
            Menu(); 
        }

        public static void Sair()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}
