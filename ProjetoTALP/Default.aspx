<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjetoTALP._Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Scripts/estilo.css">
    <br/>
    <br/>
    <div class="container" class="jumbotron" style="background-color: rgba(23, 60, 85, 0.9);  border-radius: 10px; color: white">

        <div class="row">
          <div class="col-sm-12">
            <p><h3 style="text-align: center;"><b>CADASTRO</b></h3></p>
          </div>
          <br />
        </div>

        <div class="row">
          <div class="col-sm-4">      
                <b>CNPJ:</b>
                <br/>
                <asp:TextBox ID="txtCnpj" runat="server" placeholder="Digite o CNPJ:" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validaCnpj" runat="server" ErrorMessage="Informe algum cnpj" ControlToValidate ="txtCnpj" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
                <b>Razão social:</b>
                <br/>
                <asp:TextBox ID="txtNome" runat="server" placeholder="Digite a razao social:" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validaNome" runat="server" ErrorMessage="Informe uma razao social" ControlToValidate ="txtNome" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
          </div>
          <div class="col-sm-4">
                <b>Endereço:</b>
                <br/>
                <asp:TextBox ID="txtEndereco" runat="server" placeholder="Digite o endereço:" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validaEndereco" runat="server" ErrorMessage="Informe um endereco" ControlToValidate ="txtEndereco" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
                <b>Telefone:</b>
                <br/>
                <asp:TextBox ID="txtTelefone" runat="server" placeholder="Digite o telefone:" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validaTelefone" runat="server" ErrorMessage="Informe um telefone" ControlToValidate ="txtTelefone" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
          </div>
          <div class="col-sm-4">
                <b>Email:</b>
                <br/>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Digite o email:" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validaemail" runat="server" ErrorMessage="Informe um email" ControlToValidate ="txtEmail" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
                <b>Senha:</b>
                <br/>
                <asp:TextBox ID="txtSenha" runat="server" placeholder="Digite a senha:" TextMode ="Password" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validasenha" runat="server" ErrorMessage="Informe uma senha" ControlToValidate ="txtSenha" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
          </div>
        </div>
        <div class="row">
          <div class="col-sm-12">
              <asp:Button ID="cmdEnviar" runat="server" class="btn btn-primary" Text="Enviar" OnClick="cmdEnviar_Click" />
              <asp:Button ID="cmdAtualizar" runat="server" class="btn btn-success" Text="Atualizar" OnClick="cmdExcluir_Click" />
              <asp:Button ID="cmdExcluir" runat="server" class="btn btn-danger" Text="Excluir" OnClick="cmdExcluir_Click" />
           
          
            <br />
            <br />
            <br />
          </div>
        </div>
        <div class="row">
          <div class="col-sm-12">         
                <asp:Label Text="" ID="lblResultado" runat="server"></asp:Label>               
                <asp:GridView ID="grudUsuario" Width="100%" GridLines="Both" runat="server" 
                    AutoGenerateColumns="false" OnRowCommand="grudUsuario_RowCommand" 
                    OnPageIndexChanging="grudUsuario_PageIndexChanging"
                    DataKeyNames="IdInstituicao" AllowPaging="true" PageSize="5">
                    <PagerSettings Mode="Numeric" />
                    <Columns>
                        <asp:BoundField DataField="IdInstituicao" HeaderText="IdInstituicao" />
                        <asp:BoundField DataField="cnpj" HeaderText="CNPJ" />
                        <asp:BoundField DataField="NomeInstituicao" HeaderText="Razão Social" />
                        <asp:BoundField DataField="EnderecoInstituicao" HeaderText="Endereço" />
                        <asp:BoundField DataField="TelefoneInstituicao" HeaderText="Telefone" />
                        <asp:BoundField DataField="EmailInstituicao" HeaderText="Email" />
                        <asp:ButtonField ButtonType="Button" Text="Excluir"   CommandName="Excluir" />
                        <asp:ButtonField ButtonType="Button" Text="Atualizar" CommandName="Atualizar" />
                    </Columns>
                </asp:GridView>
             <br />
            <br />
          </div>
        </div>           
          
  
           
        </div>
</asp:Content>
