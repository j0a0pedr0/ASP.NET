using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamado
{
   

    internal class Chamado
    {
        public int Codigo { get; set; }
        public string? Empresa { get; set; }
        public int? TipoChamada { get; set; }
        public DateTime DataChamada { get; set; }
        public string? Descricao { get; set; }

        
        public void Validar() { 
        }

        public void Gravar()
        {

        }

        public void Listar()
        {

        }

        public void Remover()
        {

        }
    }
}
