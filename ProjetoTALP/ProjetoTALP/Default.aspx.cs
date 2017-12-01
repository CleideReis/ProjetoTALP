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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                preencherGrid();
        }

        private void preencherGrid()
        {
            ProjetoTALP.Negocio.BLL.InstituicaoBLL _instituicaoBLL = new Negocio.BLL.InstituicaoBLL();
            this.grudUsuario.DataSource = _instituicaoBLL.buscarInstituicoes();
            this.grudUsuario.DataBind();
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            //preenche o objeto DTO para enviar
            ProjetoTALP.Negocio.DTO.InstituicaoDTO _instituicaoDTO = new Negocio.DTO.InstituicaoDTO();
            _instituicaoDTO.cnpj = this.txtCnpj.Text;
            _instituicaoDTO.NomeInstituicao = this.txtNome.Text;
            _instituicaoDTO.EnderecoInstituicao = this.txtEndereco.Text;
            _instituicaoDTO.TelefoneInstituicao = this.txtTelefone.Text;
            _instituicaoDTO.EmailInstituicao = this.txtEmail.Text;
            _instituicaoDTO.Senha = this.txtSenha.Text;
            //chama o metodo de negocio
            ProjetoTALP.Negocio.BLL.InstituicaoBLL _instituicaoBLL = new Negocio.BLL.InstituicaoBLL();
            //chama o método de insert dentro da classe de negocio
            if (_instituicaoBLL.insertInstituicao(_instituicaoDTO))
            {
                // mostra que foi executado com sucesso
                this.lblResultado.Text = "Instituição inserida com sucesso!!!";
                this.preencherGrid();
            }
            else
                this.lblResultado.Text = "Erro ao tentar inserir a instituição, por favor tente novamente.";
        }

        protected void cmdExcluir_Click(object sender, EventArgs e)
        {

            ProjetoTALP.Negocio.DTO.InstituicaoDTO _instituicaoDTO = new Negocio.DTO.InstituicaoDTO();
            _instituicaoDTO.cnpj = this.txtCnpj.Text;
            _instituicaoDTO.NomeInstituicao = this.txtNome.Text;
            _instituicaoDTO.EnderecoInstituicao = this.txtEndereco.Text;
            _instituicaoDTO.TelefoneInstituicao = this.txtTelefone.Text;
            _instituicaoDTO.EmailInstituicao = this.txtEmail.Text;
            _instituicaoDTO.Senha = this.txtSenha.Text;

            ProjetoTALP.Negocio.BLL.InstituicaoBLL _instituicaoBLL = new Negocio.BLL.InstituicaoBLL();

            if (_instituicaoBLL.deleteInstituicao(_instituicaoDTO))
            {
                lblResultado.Text = "Instituição excluída com sucesso!!!";
                preencherGrid();
            }
            else
            {
                lblResultado.Text = "Instituição não pode ser excluída, favor tente novamente!";
            }

        }
        protected void grudUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                int _index = int.Parse((string)e.CommandArgument);
                
                string _chave = grudUsuario.DataKeys[_index]["IdInstituicao"].ToString();
                
                InstituicaoDTO _dto = new InstituicaoDTO();
                if (!String.IsNullOrEmpty(_chave))
                    _dto.IdInstituicao = long.Parse(_chave);

                InstituicaoBLL _bll = new InstituicaoBLL();
                if (_bll.deleteInstituicao(_dto))
                    preencherGrid();



            }
            if (e.CommandName == "Atualizar")
            {
               
                int _index = int.Parse((string)e.CommandArgument);
                

                string _chave = grudUsuario.DataKeys[_index]["IdInstituicao"].ToString();

                string _cnpj = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[1].Text);
                string _nome = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[2].Text);
                string _endereco = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[3].Text);
                string _telefone = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[4].Text);
                string _email = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[5].Text);
                string _senha = Server.HtmlDecode(grudUsuario.Rows[_index].Cells[6].Text);

                txtCnpj.Text = _cnpj;
                txtCnpj.Focus();
                txtNome.Text = _nome;
                txtNome.Focus();
                txtEndereco.Text = _endereco;
                txtEndereco.Focus();
                txtTelefone.Text = _telefone;
                txtTelefone.Focus();
                txtEmail.Text = _email;
                txtEmail.Focus();
                txtSenha.Text = _senha;
                txtSenha.Focus();

                InstituicaoDTO _dto = new InstituicaoDTO();
                if (!String.IsNullOrEmpty(_chave))
                    _dto.IdInstituicao = long.Parse(_chave);

                //acessa a business passando a dto
                InstituicaoBLL _bll = new InstituicaoBLL();
                if (_bll.updateInstituicao(_dto))
                    //Response.Redirect("About.aspx");
                    preencherGrid();
                
            }
        }

        protected void grudUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grudUsuario.PageIndex = e.NewPageIndex;
            preencherGrid();
        }

        protected void cmdAtualizar_Click(object sender, EventArgs e)
        {
            ProjetoTALP.Negocio.DTO.InstituicaoDTO _instituicaoDTO = new Negocio.DTO.InstituicaoDTO();
            _instituicaoDTO.cnpj = this.txtCnpj.Text;
            _instituicaoDTO.NomeInstituicao = this.txtNome.Text;
            _instituicaoDTO.EnderecoInstituicao = this.txtEndereco.Text;
            _instituicaoDTO.TelefoneInstituicao = this.txtTelefone.Text;
            _instituicaoDTO.EmailInstituicao = this.txtEmail.Text;
            _instituicaoDTO.Senha = this.txtSenha.Text;

            ProjetoTALP.Negocio.BLL.InstituicaoBLL _instituicaoBLL = new Negocio.BLL.InstituicaoBLL();

            if (_instituicaoBLL.updateInstituicao(_instituicaoDTO))
            {
                lblResultado.Text = "Instituição alterada com sucesso!!!";
                preencherGrid();
            }
            else
            {
                lblResultado.Text = "Instituição não pode ser alterada, por favor tente novamente!";
            }
        }
    }
}