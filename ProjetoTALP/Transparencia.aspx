<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transparencia.aspx.cs" Inherits="ProjetoTALP.Transparencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Scripts/bootstrap.css" rel="stylesheet" />

    <h1>TABELA DE DOAÇÕES</h1>
    <asp:GridView ID="grudUsuario" runat="server" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField DataField="cnpj" HeaderText="CNPJ" />
            <asp:BoundField DataField="NomeInstituicao" HeaderText="INSTITUIÇÃO" />
            <asp:BoundField DataField="EnderecoInstituicao" HeaderText="ENDEREÇO" />
            <asp:BoundField DataField="IdDoacao" HeaderText="NRO DOAÇÃO" />
            <asp:BoundField DataField="Categoria" HeaderText="CATEGORIA" />
            <asp:BoundField DataField="Quantidade" HeaderText="QUANTIDADE" />
            <asp:BoundField DataField="Definicao" HeaderText="DEFINIÇÃO/OBJETO" /> 
            <asp:BoundField DataField="Estatus" HeaderText="STATUS" />
       </Columns>
    </asp:GridView>
    <br /><br />
     <div class="grafico-estatisticas">
    <h3>Gráfico de doações 2017</h3>
      <div class="grafic">
        <div class="col-1">
          <span>1.852</span>
          <p>JANEIRO</p>
        </div>

        <div class="col-3">
          <span>6.832</span>
          <p>FEVEREIRO</p>
        </div>

        <div class="col-5">
          <span>21.651</span>
          <p>MARÇO</p>
        </div>

        <div class="col-6">
          <span>55.496</span>
          <p>ABRIL</p>
        </div>

        <div class="col-4">
          <span>10.971</span>
          <p>MAIO</p>
        </div>

        <div class="col-2">
          <span>5.9</span>
          <p>JUNHO</p>
        </div>

        <div class="col-8">
          <span>90.475</span>
          <p>JULHO</p>
          <p></p>
        </div>

        <div class="col-7">
          <span>62.514</span>
          <p>AGOSTO</p>
        </div>
      </div>

     
  </div>
</asp:Content>
