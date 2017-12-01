using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoTALP
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            ProjetoTALP.Negocio.DTO.DoadorDTO _doadorDTO = new Negocio.DTO.DoadorDTO();
            ProjetoTALP.Negocio.DTO.InstituicaoDTO _instituicaoDTO = new Negocio.DTO.InstituicaoDTO();
            ProjetoTALP.Negocio.BLL.DoadorBLL _doadorBLL = new Negocio.BLL.DoadorBLL();
            ProjetoTALP.Negocio.BLL.InstituicaoBLL _instuicaoBLL = new Negocio.BLL.InstituicaoBLL();

            

            if(this.radiodoador.Checked)
            {
                _doadorDTO.Email = this.txtEmail.Text;
                _doadorDTO.Senha = this.txtSenha.Text;
                _doadorDTO = _doadorBLL.verificaLoginDoador(_doadorDTO);

                if ( null != _doadorDTO)
                {
                    Session["USUARIO"] = _doadorDTO;
                    Response.Redirect("Doacao.aspx");
                }
                else
                    this.lblResultado.Text = "Usuário ou senha inválido!";
            } else
            {
                _instituicaoDTO.EmailInstituicao = this.txtEmail.Text;
                _instituicaoDTO.Senha = this.txtSenha.Text;
                _instituicaoDTO = _instuicaoBLL.verificaLoginInstuicao(_instituicaoDTO);

                if (null != _instituicaoDTO)
                {
                    Session["USUARIO"] = _instituicaoDTO;
                    Response.Redirect("Pagina2.aspx");
                }
                else
                    this.lblResultado.Text = "Instuição ou senha inválido!";
            }


        }
    }
}