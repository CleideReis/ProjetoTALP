using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoTALP
{
    public partial class Contato : System.Web.UI.Page
    {
        public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {


            SmtpClient cliente = new SmtpClient();
            cliente.Host = "smtp.gmail.com";
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.EnableSsl = true;
            cliente.Port = 587;

            System.Net.NetworkCredential credenciais = new System.Net.NetworkCredential("buckmancleide@gmail.com", "@123menino");
            cliente.Credentials = credenciais;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("buckmancleide@gmail.com");
            mail.To.Add(new MailAddress(txtEmail.Text));
            mail.Body = " Mensagem do site:<br/> Nome:  " + txtNome.Text + "<br/> Email : " + txtEmail.Text + " <br/> Mensagem : " + txtMsg.Text;

            try
            {

                cliente.Send(mail);
                Response.Write("<script language='javascript'>alert('E-mail enviado com sucesso!');</script>");

            }
            catch (Exception)
            {
                Response.Write("<script language='javascript'>alert('Erro: Favor informar novamente!');</script>");
            }


        }
    }
}