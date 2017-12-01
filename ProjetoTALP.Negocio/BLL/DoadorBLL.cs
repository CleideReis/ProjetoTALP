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
    public class DoadorBLL
    {
        private DoadorDAL _doadorDAL;
        
        public DoadorBLL()
        {
            if (_doadorDAL == null)
                _doadorDAL = new DAL.DoadorDAL();
        }
        
        public Boolean insertDoador(DoadorDTO dto)
        {
            return _doadorDAL.insertDoador(dto);
        }

        public Boolean updateDoador(DoadorDTO dto)
        {
            return _doadorDAL.updateDoador(dto);
        }

        public Boolean deleteDoador(DoadorDTO dto)
        {
            return _doadorDAL.deleteDoador(dto);
        }

        public DataTable selectDoador()
        {
            return _doadorDAL.selectDoador();
        }

        public DoadorDTO verificaLoginDoador(DoadorDTO dto)
        {
            return _doadorDAL.verificaLoginDoador(dto);
        }
    }
}
