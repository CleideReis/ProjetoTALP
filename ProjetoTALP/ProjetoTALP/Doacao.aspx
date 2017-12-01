<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Doacao.aspx.cs" Inherits="ProjetoTALP.Doacao" %>

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
                <b>Categoria:</b>
                <br/>
                <asp:TextBox ID="txtCategoria" runat="server" placeholder="Digite a categoria:" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validaCategoria" runat="server" ErrorMessage="Informe uma categoria" ControlToValidate ="txtCategoria" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
                
          </div>
          <div class="col-sm-4">
                <b>Quantidade:</b>
                <br/>
                <asp:TextBox ID="txtQuantidade" runat="server" placeholder="Digite a quantidade:" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validaQuantidade" runat="server" ErrorMessage="Informe alguma quantidade" ControlToValidate ="txtQuantidade" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
        
          </div>
            <div class="col-sm-4">
                <b>Definição:</b>
                <br/>
                <asp:TextBox ID="txtDefinicao" runat="server" placeholder="Digite a definição do objeto:" class="areatexto"/>
                <br />
                <asp:RequiredFieldValidator ID="validaDefinicao" runat="server" ErrorMessage="Informe uma definição" ControlToValidate ="txtDefinicao" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
        
          </div>
        </div>

        <div class="row">
          <div class="col-sm-12">         
                               
                <asp:GridView ID="GridView1" Width="100%" GridLines="Both" runat="server" 
                    AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" 
                    OnPageIndexChanging="GridView1_PageIndexChanging"
                    DataKeyNames="IdInstituicao" AllowPaging="true" PageSize="5">
                    <PagerSettings Mode="Numeric" />
                    <Columns>
                        <asp:BoundField DataField="IdInstituicao" HeaderText="IdInstituicao" />
                        <asp:BoundField DataField="cnpj" HeaderText="CNPJ" />
                        <asp:BoundField DataField="NomeInstituicao" HeaderText="Razão Social" />
                        <asp:BoundField DataField="EnderecoInstituicao" HeaderText="Endereço" />
                        <asp:BoundField DataField="TelefoneInstituicao" HeaderText="Telefone" />
                        <asp:BoundField DataField="EmailInstituicao" HeaderText="Email" />
                        <asp:ButtonField ButtonType="Button" Text="Selecionar"   CommandName="Selecionar" />
                      
                    </Columns>
                </asp:GridView>
             <br />
            <br />
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
                    DataKeyNames="IdDoacao" AllowPaging="true" PageSize="5">
                    <PagerSettings Mode="Numeric" />
                    <Columns>
                        <asp:BoundField DataField="cnpj" HeaderText="CNPJ" />
                        <asp:BoundField DataField="NomeInstituicao" HeaderText="INSTITUIÇÃO" />
                        <asp:BoundField DataField="EnderecoInstituicao" HeaderText="ENDEREÇO" />
                        <asp:BoundField DataField="IdDoacao" HeaderText="NRO DOAÇÃO" />
                        <asp:BoundField DataField="Categoria" HeaderText="CATEGORIA" />
                        <asp:BoundField DataField="Quantidade" HeaderText="QUANTIDADE" />
                        <asp:BoundField DataField="Definicao" HeaderText="DEFINIÇÃO/OBJETO" /> 
                        <asp:BoundField DataField="Estatus" HeaderText="STATUS" />
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

