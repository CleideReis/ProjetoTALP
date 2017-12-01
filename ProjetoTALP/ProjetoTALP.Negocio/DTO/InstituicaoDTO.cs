using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTALP.Negocio.DTO
{
    public class InstituicaoDTO
    {
        public Int64 IdInstituicao { get; set; }
        public String cnpj { get; set; }
        public String NomeInstituicao { get; set; }
        public String EnderecoInstituicao { get; set; }
        public String TelefoneInstituicao { get; set; }
        public String EmailInstituicao { get; set; }
        public String Senha { get; set; }
    }
}
