using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTALP.Negocio.DTO
{
    public class DoacaoDTO
    {
        public Int64 IdDoacao { get; set; }
        public String Categoria { get; set; }
        public Int32 Quantidade { get; set; }
        public String Definicao { get; set; }
        public Int32 IdInstituicao { get; set; }
        public Int32 IdDoador { get; set; }
        public Char Estatus { get; set; }
    }
}
