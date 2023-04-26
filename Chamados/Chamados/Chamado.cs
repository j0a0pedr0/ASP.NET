using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Chamados
{
    public class Chamado
    {

        public Chamado() { }

        public string Empresa { get; set; }
        public  void Gravar()
        {
            Console.Clear();
            Console.WriteLine("||------------------------------------------------------||");
            Console.WriteLine("||-------------------INICIAR NOVO CHAMADO---------------||");
            Console.WriteLine("||------------------------------------------------------||");
            Console.WriteLine("Pediremos as seguintes informações");
            Console.WriteLine(" ");
            Console.WriteLine("1-)Empresa Solicitante");
            Console.WriteLine("2-)Nome do funcionário");
            Console.WriteLine("3-)Departamento");
            Console.WriteLine("4-)Descricao do Chamado");
            Console.WriteLine(" ");
 

            Console.Write("Por Favor, Digite o Nome Da Empresa---------:");
            string? Empresa = Console.ReadLine();
            Console.Clear();

            if (Empresa == " " || Empresa?.Length < 3)
            {
                while(Empresa.Length < 3 || Empresa == "")
                {

                    Console.Write("Compo deve ter no mínimo 3 caracteres... Digite novamente o nome da Empresa:---------:");
                    string? incremento = Console.ReadLine();
                    Empresa = incremento;
                    Console.Clear();

                }

            }

            Console.Write("Digite o Nome Do Funcionário:---------:");
            string? Funcionário = Console.ReadLine();
            Console.Clear();

            if (Funcionário == " " || Funcionário?.Length < 3)
            {
                while (Funcionário.Length < 3 || Funcionário == "")
                {

                    Console.Write("Compo deve ter no mínimo 3 caracteres... Digite novamente o Nome Do Funcionário:---------:");
                    string? incremento = Console.ReadLine();
                    Funcionário = incremento;
                    Console.Clear();

                }

            }



            Console.WriteLine(" ");
            Console.WriteLine("||---Departamentos----||:");
            Console.WriteLine(" ");
            Console.WriteLine(" 1-) Suporte técnico");
            Console.WriteLine(" 2-) Suporte Financeiro");
            Console.WriteLine(" ");

            Console.Write("Escolha um Departamento Procurado Digitando o Numero Correspondente: ex: 1 = 1-) Suporte tecnico :---------:");
            string Departamento = Console.ReadLine();
            Console.Clear();

            if (Departamento != "1" && Departamento!= "2")
            {
                while (Departamento != "1" && Departamento != "2")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("||---Departamentos----||:");
                    Console.WriteLine(" ");
                    Console.WriteLine(" 1-) Suporte técnico");
                    Console.WriteLine(" 2-) Suporte Financeiro");
                    Console.WriteLine(" ");

                    Console.Write("Escolha Uma Das Opições listadas acima");
                    string incremento = Console.ReadLine();
                    Departamento = incremento;
                    Console.Clear();

                }

            }


            Console.Write("Por Favor, Informe uma breve descrição:---------:");
            string? Descricao = Console.ReadLine();
            Console.Clear();

            if (Descricao == " " || Descricao?.Length < 3)
            {
                while (Descricao.Length < 12 || Descricao == " ")
                {

                    Console.Write("Campo deve ter no mínimo 12 caracteres... Digite novamente a descricão:---------:");
                    string? incremento = Console.ReadLine();
                    Descricao = incremento;
                    Console.Clear();

                }

            }
            Console.WriteLine("||---------------------------------------||");
            Console.WriteLine("||-----CHAMADO INICIADO COM SUCESSO!-----||");
            Console.WriteLine("||---------------------------------------||");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Pressione a Tecla ENTER Para Ir Pro Menu de Ações");
            Console.ReadLine();
            Console.Clear();
            Painel.Menu();
            Console.Clear();
        }

        public void Remover()
        {

        }

        public void Listar()
        {

        }

        /*public void ValidarEmpresa(string Empresa)
        {
            bool ? resultado = false;

            if(Empresa == " " || Empresa.Length < 3)
            {
                resultado = true;
            }
            return resultado;

        }*/

    }
}
