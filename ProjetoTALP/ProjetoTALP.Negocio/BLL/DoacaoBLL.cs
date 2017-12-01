using ProjetoTALP.Negocio.DAL;
using ProjetoTALP.Negocio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTALP.Negocio.BLL
{
    public class DoacaoBLL
    {
        private DoacaoDAL _doacaoDAL;

        public DoacaoBLL()
        {
            if (_doacaoDAL == null)
                _doacaoDAL = new DAL.DoacaoDAL();
        }

        public Boolean insertDoacao(DoacaoDTO dto)
        {
            return _doacaoDAL.insertDoacao(dto);
        }

        public Boolean updateDoacao(DoacaoDTO dto)
        {
            return _doacaoDAL.updateDoacao(dto);
        }

        public Boolean deleteDoacao(DoacaoDTO dto)
        {
            return _doacaoDAL.deleteDoacao(dto);
        }

        public Boolean alterarStatus(DoacaoDTO dto)
        {
            return _doacaoDAL.alterarStatus(dto);
        }

        public DataTable selectDoacao()
        {
            return _doacaoDAL.selectDoacao();
        }
    }
}
