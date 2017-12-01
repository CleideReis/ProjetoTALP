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


    public class InstituicaoBLL
    {
        private InstituicaoDAL _instituicaoDAL;
        /// <summary>
        /// Se a instacia de _usuarioDAL estiver null, gera uma nova instancia
        /// </summary>
        public InstituicaoBLL()
        {
            if (_instituicaoDAL == null)
                _instituicaoDAL = new DAL.InstituicaoDAL();
        }
        /// <summary>
        /// Método responsável pela regra de negócios da instituicao
        /// No momento de inserir valores
        /// </summary>
        /// <param name="dto">InstituicaoDTO</param>
        /// <returns>Boolean</returns>
        public Boolean insertInstituicao(InstituicaoDTO dto)
        {
            return _instituicaoDAL.insertInstituicao(dto);
        }

        public Boolean updateInstituicao(InstituicaoDTO dto)
        {
            return _instituicaoDAL.updateInstituicao(dto);
        }

        public Boolean deleteInstituicao(InstituicaoDTO dto)
        {
            return _instituicaoDAL.deleteInstituicao(dto);
        }

        public DataTable buscarInstituicoes()
        {
            return _instituicaoDAL.buscarInstituicoes();
        }
        public InstituicaoDTO verificaLoginInstuicao(InstituicaoDTO dto)
        {
            return _instituicaoDAL.verificaLoginInstuicao(dto);
        }
    }
}
