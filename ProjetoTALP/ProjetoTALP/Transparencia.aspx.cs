using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoTALP
{
    public partial class Transparencia : System.Web.UI.Page
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
    }
}