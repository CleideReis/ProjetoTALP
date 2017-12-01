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
    public partial class Doador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                preencherGrid();
        }

        private void preencherGrid()
        {
            ProjetoTALP.Negocio.BLL.DoadorBLL _doadorBLL = new Negocio.BLL.DoadorBLL();
            this.grudUsuario.DataSource = _doadorBLL.selectDoador();
            this.grudUsuario.DataBind();
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            //preenche o objeto DTO para enviar
            ProjetoTALP.Negocio.DTO.DoadorDTO _doadorDTO = new Negocio.DTO.DoadorDTO();
            _doadorDTO.cpf = this.txtCpf.Text;
            _doadorDTO.Nome = this.txtNome.Text;
            _doadorDTO.Endereco = this.txtEndereco.Text;
            _doadorDTO.Telefone = this.txtTelefone.Text;
            _doadorDTO.Email = this.txtEmail.Text;
            _doadorDTO.Senha = this.txtSenha.Text;
            //chama o metodo de negocio
            ProjetoTALP.Negocio.BLL.DoadorBLL _doadorBLL = new Negocio.BLL.DoadorBLL();
            //chama o método de insert dentro da classe de negocio
            if (_doadorBLL.insertDoador(_doadorDTO))
            {
                // mostra que foi executado com sucesso
                this.lblResultado.Text = "Doador inserido com sucesso!!!";
                this.preencherGrid();
            }
            else
                this.lblResultado.Text = "Erro ao tentar inserir o doador, por favor tente novamente.";
        }

        protected void cmdExcluir_Click(object sender, EventArgs e)
        {

            ProjetoTALP.Negocio.DTO.DoadorDTO _doadorDTO = new Negocio.DTO.DoadorDTO();
            _doadorDTO.cpf = this.txtCpf.Text;
            _doadorDTO.Nome = this.txtNome.Text;
            _doadorDTO.Endereco = this.txtEndereco.Text;
            _doadorDTO.Telefone = this.txtTelefone.Text;
            _doadorDTO.Email = this.txtEmail.Text;
            _doadorDTO.Senha = this.txtSenha.Text;
            //chama o metodo de negocio
            ProjetoTALP.Negocio.BLL.DoadorBLL _doadorBLL = new Negocio.BLL.DoadorBLL();

            if (_doadorBLL.deleteDoador(_doadorDTO))
            {
                lblResultado.Text = "Doador excluído com sucesso!!!";
                preencherGrid();
            }
            else
            {
                lblResultado.Text = "Doador não pode ser excluído, favor tente novamente!";
            }

        }
        protected void grudUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                
                int _index = int.Parse((string)e.CommandArgument);
                
                string _chave = grudUsuario.DataKeys[_index]["IdDoador"].ToString();
                
                DoadorDTO _dto = new DoadorDTO();
                if (!String.IsNullOrEmpty(_chave))
                    _dto.IdDoador = long.Parse(_chave);

                DoadorBLL _bll = new DoadorBLL();
                if (_bll.deleteDoador(_dto))
                    //Response.Redirect("About.aspx");
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


        protected void cmdAtualizar_Click(object sender, EventArgs e)
        {
            ProjetoTALP.Negocio.DTO.DoadorDTO _doadorDTO = new Negocio.DTO.DoadorDTO();
            _doadorDTO.cpf = this.txtCpf.Text;
            _doadorDTO.Nome = this.txtNome.Text;
            _doadorDTO.Endereco = this.txtEndereco.Text;
            _doadorDTO.Telefone = this.txtTelefone.Text;
            _doadorDTO.Email = this.txtEmail.Text;
            _doadorDTO.Senha = this.txtSenha.Text;

            ProjetoTALP.Negocio.BLL.DoadorBLL _doadorBLL = new Negocio.BLL.DoadorBLL();

            if (_doadorBLL.updateDoador(_doadorDTO))
            {
                lblResultado.Text = "Doador alterado com sucesso!!!";
                preencherGrid();
            }
            else
            {
                lblResultado.Text = "Doador não pode ser alterado, por favor tente novamente!";
            }
        }
    }
}