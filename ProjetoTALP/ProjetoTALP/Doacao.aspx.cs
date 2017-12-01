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
    public partial class Doacao : System.Web.UI.Page
    {
        int idInstituicao;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                preencherGrid();
                preencherGrid1();
            }
                
        }

        private void preencherGrid()
        {
            ProjetoTALP.Negocio.BLL.DoacaoBLL _doacaoBLL = new Negocio.BLL.DoacaoBLL();
            this.grudUsuario.DataSource = _doacaoBLL.selectDoacao();
            this.grudUsuario.DataBind();
        }

        private void preencherGrid1()
        {
            ProjetoTALP.Negocio.BLL.InstituicaoBLL _instituicaoBLL = new Negocio.BLL.InstituicaoBLL();
            this.GridView1.DataSource = _instituicaoBLL.buscarInstituicoes();
            this.GridView1.DataBind();
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            
            ProjetoTALP.Negocio.DTO.DoacaoDTO _doacaoDTO = new Negocio.DTO.DoacaoDTO();
            ProjetoTALP.Negocio.DTO.DoadorDTO _doadorDTO = new Negocio.DTO.DoadorDTO();

            _doadorDTO = (DoadorDTO) this.Session["USUARIO"];

            _doacaoDTO.Categoria = this.txtCategoria.Text;
            _doacaoDTO.Quantidade = int.Parse(this.txtQuantidade.Text);
            _doacaoDTO.Definicao = this.txtDefinicao.Text;
            _doacaoDTO.IdDoador = Convert.ToInt16(_doadorDTO.IdDoador);
            _doacaoDTO.IdInstituicao = idInstituicao;

            ProjetoTALP.Negocio.BLL.DoacaoBLL _doacaoBLL = new Negocio.BLL.DoacaoBLL();
            
            if (_doacaoBLL.insertDoacao(_doacaoDTO))
            {
                this.lblResultado.Text = "Doação inserida com sucesso!!!";
                this.preencherGrid();
            }
            else
                this.lblResultado.Text = "Erro ao tentar inserir a doação, por favor tente novamente.";
        }

        protected void cmdExcluir_Click(object sender, EventArgs e)
        {

            ProjetoTALP.Negocio.DTO.DoacaoDTO _doacaoDTO = new Negocio.DTO.DoacaoDTO();
            ProjetoTALP.Negocio.DTO.DoadorDTO _doadorDTO = new Negocio.DTO.DoadorDTO();

            _doadorDTO = (DoadorDTO)this.Session["USUARIO"];

            _doacaoDTO.Categoria = this.txtCategoria.Text;
            _doacaoDTO.Quantidade = int.Parse(this.txtQuantidade.Text);
            _doacaoDTO.Definicao = this.txtDefinicao.Text;
            _doacaoDTO.IdDoador = Convert.ToInt16(_doadorDTO.IdDoador);
           _doacaoDTO.IdInstituicao = idInstituicao;

            ProjetoTALP.Negocio.BLL.DoacaoBLL _doacaoBLL = new Negocio.BLL.DoacaoBLL();

            if (_doacaoBLL.deleteDoacao(_doacaoDTO))
            {
                lblResultado.Text = "Doação excluída com sucesso!!!";
                preencherGrid();
            }
            else
            {
                lblResultado.Text = "Doação não pode ser excluída, favor tente novamente!";
            }

        }
        protected void grudUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {

                int _index = int.Parse((string)e.CommandArgument);

                string _chave = grudUsuario.DataKeys[_index]["IdDoacao"].ToString();

                DoacaoDTO _dto = new DoacaoDTO();
                if (!String.IsNullOrEmpty(_chave))
                    _dto.IdDoacao = long.Parse(_chave);

                DoacaoBLL _bll = new DoacaoBLL();
                if (_bll.deleteDoacao(_dto))                   
                    preencherGrid();



            }
            else if (e.CommandName == "Atualizar")
            {

                //        int _index = int.Parse((string)e.CommandArgument);


                //        string _chave = grudUsuario.DataKeys[_index]["IdDoador"].ToString();

                //        string _cpf = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[1].Text);
                //        string _nome = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[2].Text);
                //        string _endereco = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[3].Text);
                //        string _telefone = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[4].Text);
                //        string _email = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[5].Text);
                //        string _senha = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[6].Text);

                //        txtCpf.Text = _cpf;
                //        txtCpf.Focus();
                //        txtNome.Text = _nome;
                //        txtNome.Focus();
                //        txtEndereco.Text = _endereco;
                //        txtEndereco.Focus();
                //        txtTelefone.Text = _telefone;
                //        txtTelefone.Focus();
                //        txtEmail.Text = _email;
                //        txtEmail.Focus();
                //        txtSenha.Text = _senha;
                //        txtSenha.Focus();

                //        IDoadorDTO _dto = new DoadorDTO();
                //        if (!String.IsNullOrEmpty(_chave))
                //            _dto.IdDoador = long.Parse(_chave);

                //        DoadorBLL _bll = new DoadorBLL();
                //        if (_bll.updateDoador(_dto))
                //            //Response.Redirect("About.aspx");
                //            preencherGrid();

            }
        }

        protected void grudUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grudUsuario.PageIndex = e.NewPageIndex;
            preencherGrid();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            preencherGrid1();
        }


        protected void cmdAtualizar_Click(object sender, EventArgs e)
        {
            //ProjetoTALP.Negocio.DTO.DoacaoDTO _doacaoDTO = new Negocio.DTO.DoacaoDTO();
            //_doacaoDTO.Categoria = this.txtCategoria.Text;
            //_doacaoDTO.Quantidade = this.txtQuantidade.Text;
            //_doacaoDTO.Definicao = this.txtDefinicao.Text;
            //_doacaoDTO.IdInstituicao = this.txtTelefone.Text;
            //_doacaoDTO.Email = this.txtEmail.Text;
            

            //ProjetoTALP.Negocio.BLL.DoacaoBLL _doacaoBLL = new Negocio.BLL.DoacaoBLL();

            //if (_doacaoBLL.updateDoacao(_doacaoDTO))
            //{
            //    lblResultado.Text = "Doador alterado com sucesso!!!";
            //    preencherGrid();
            //}
            //else
            //{
            //    lblResultado.Text = "Doador não pode ser alterado, por favor tente novamente!";
            //}
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Selecionar")
            {

                int _index = int.Parse((string)e.CommandArgument);

                string _chave = GridView1.DataKeys[_index]["IdInstituicao"].ToString();

                InstituicaoDTO _dto = new InstituicaoDTO();
                if (!String.IsNullOrEmpty(_chave))
                    _dto.IdInstituicao = long.Parse(_chave);

                idInstituicao = Convert.ToInt16(_dto.IdInstituicao);



            }
        }
    }
}