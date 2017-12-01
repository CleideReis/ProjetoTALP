using ProjetoTALP.Negocio.BLL;
using ProjetoTALP.Negocio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoTALP
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
                preencherGrid();
        }

        private void preencherGrid()
        {
            ProjetoTALP.Negocio.BLL.DoacaoBLL _doacaoBLL = new Negocio.BLL.DoacaoBLL();
            this.grudUsuario.DataSource = _doacaoBLL.selectDoacao();
            this.grudUsuario.DataBind();
        }

        protected void grudUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "MudarStatus")
            {

                int _index = int.Parse((string)e.CommandArgument);

                string _chave = grudUsuario.DataKeys[_index]["IdDoacao"].ToString();

                DoacaoDTO _dto = new DoacaoDTO();
                if (!String.IsNullOrEmpty(_chave))
                    _dto.IdDoacao = long.Parse(_chave);

                DoacaoBLL _bll = new DoacaoBLL();
                if (_bll.alterarStatus(_dto))
                    preencherGrid();



            }
        }
        }
}