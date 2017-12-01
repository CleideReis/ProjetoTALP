using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTALP.Negocio.DTO
{
    public class DoadorDTO
    {
        public Int64 IdDoador { get; set; }
        public String cpf { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
    }
}
