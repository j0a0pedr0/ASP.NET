using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamado
{
        public class Chamado
        {
        public int Código { get; set; }
        public string? Empresa { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataChamada { get; set; }

        public Chamado() 
        {
            DataChamada = DateTime.Now;
        }

        public static void Gravar()
        {

        }
        public static void Listar()
        {

        }

        public static void Remover()
        {

        }

    }
}
