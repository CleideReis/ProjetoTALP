<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="ProjetoTALP.Contato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <div class="form-group">
      <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label><br />
      <asp:TextBox ID="txtNome" runat="server" class="form-control"  ></asp:TextBox>
     
  </div>
  <div class="form-group">
      <asp:Label ID="lblEmail" runat="server" Text="E-mail:"></asp:Label><br />
      <asp:TextBox ID="txtEmail" runat="server" class="form-control"  ></asp:TextBox>
     
  </div>
   
  <div class="form-group">
      <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label><br />
      <asp:TextBox ID="txtSenha" runat="server" type="password" class="form-control" ></asp:TextBox>
  
  </div>
 
    <div class="form-group">
        <asp:Label ID="lblMsg" runat="server" Text="Mensagem:"></asp:Label><br />
    
        <asp:TextBox ID="txtMsg" runat="server" class="form-control" ></asp:TextBox>
    </div>
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" class="btn btn-default" OnClick="btnEnviar_Click" />
</asp:Content>
