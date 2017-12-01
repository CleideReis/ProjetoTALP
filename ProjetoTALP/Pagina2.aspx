<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="ProjetoTALP.Pagina2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
                        <asp:ButtonField ButtonType="Button" Text="MudarStatus" CommandName="MudarStatus" />
                    </Columns>
                </asp:GridView>
             <br />
            <br />
          </div>
        </div>   
</asp:Content>
