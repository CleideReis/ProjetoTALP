<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ProjetoTALP.Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     
<!DOCTYPE html><html>
<head>
    <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="../bower_components/bootstrap/dist/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="../bower_components/bootstrap-daterangepicker/daterangepicker-bs3.css">
        
    <script src='//production-assets.codepen.io/assets/editor/live/console_runner-079c09a0e3b9ff743e39ee2d5637b9216b3545af0de366d4b9aad9dc87e26bfd.js'></script><script src='//production-assets.codepen.io/assets/editor/live/events_runner-73716630c22bbc8cff4bd0f07b135f00a0bdc5d14629260c3ec49e5606f98fdd.js'></script><script src='//production-assets.codepen.io/assets/editor/live/css_live_reload_init-2c0dc5167d60a5af3ee189d570b1835129687ea2a61bee3513dee3a50c115a77.js'></script><meta charset='UTF-8'><meta name="robots" content="noindex"><link rel="shortcut icon" type="image/x-icon" href="//production-assets.codepen.io/assets/favicon/favicon-8ea04875e70c4b0bb41da869e81236e54394d63638a1ef12fa558a4a835f1164.ico" /><link rel="mask-icon" type="" href="//production-assets.codepen.io/assets/favicon/logo-pin-f2d2b6d2c61838f7e76325261b7195c27224080bc099486ddd6dccb469b8e8e6.svg" color="#111" /><link rel="canonical" href="https://codepen.io/abennington/pen/GZeyKr?depth=everything&order=popularity&page=45&q=pack&show_forks=false" />

<link rel='stylesheet prefetch' href='https://cdnjs.cloudflare.com/ajax/libs/Swiper/3.3.1/css/swiper.min.css'><link rel='stylesheet prefetch' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css'>
<title>Helpme</title>
<style class="cp-pen-styles">img { max-height: 100% }
.swiper-container {
        width: 100%;
        height: 400px;
    }
    .swiper-slide {
        text-align: center;
        font-size: 18px;
        background: #fff;
        /* Center slide text vertically */
        display: -webkit-box;
        display: -ms-flexbox;
        display: -webkit-flex;
        display: flex;
        -webkit-box-pack: center;
        -ms-flex-pack: center;
        -webkit-justify-content: center;
        justify-content: center;
        -webkit-box-align: center;
        -ms-flex-align: center;
        -webkit-align-items: center;
        align-items: center;
      /*width:90%;*/ 
    }</style></head><body>
<!-- Swiper --><br><br>
    <div class="swiper-container">
        <div class="swiper-wrapper">
            
            <div class="swiper-slide"><img src="Imagens/imagem1im.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem3.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem10.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem12.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem11.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem13.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem5.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem6.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem7.jpg" /></div>
            <div class="swiper-slide"><img src="Imagens/imagem9.jpg" /></div>
        </div>
        <!-- Add Pagination -->
        <div class="swiper-pagination"></div>
    </div>
        
<script src='//production-assets.codepen.io/assets/common/stopExecutionOnTimeout-b2a7b3fe212eaa732349046d8416e00a9dec26eb7fd347590fbced3ab38af52e.js'></script><script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.2/jquery.min.js'></script><script src='https://cdnjs.cloudflare.com/ajax/libs/Swiper/3.3.1/js/swiper.min.js'></script>
<script >var swiper = new Swiper('.swiper-container', {
        pagination: '.swiper-pagination',
        effect: 'coverflow',
        grabCursor: true,
        centeredSlides: true,
        spaceBetween: 0,
        //loop: true,
        autoplay: 2500,
        autoplayDisableOnInteraction: false,
        slidesPerView: 4,
        coverflow: {
            rotate: 30,
            stretch: 0,
            depth: 100,
            modifier: 1,
            slideShadows: true
        }
    });

//# sourceURL=pen.js
</script>
    
    
        
  <br /><br />  

    <div class="container">
        <div class="row">
            <div class="col-sm-8">
                <div class="jumbotron" style="background-image: url('Imagens/ceu.jpg');">
                    <p>
                        <h3 style="text-align: center;"><b>A importância da caridade!</b></h3><br><br>
                        A palavra caridade tem muitos significados, mas apenas um objetivo: auxiliar quem quer que seja nas situações difíceis e que muitas vezes parecem não ter saída. A caridade é na maioria das vezes aquela luz no final do túnel, tanto para quem a concede, como também para quem a recebe.
                        Fazer caridade é agir com sabedoria, ajudando o próximo sem esperar nada em troca e o mais importante: não divulgar o que foi feito, quando foi feito, para quem, e quanto custou!
                        Existem muitas maneiras de se praticar a caridade, não necessariamente a mesma está interligada com a posse de bens materiais. Pode-se ajudar alguém com o simples fato de ouvir, permitir que o outro desabafe, colocando assim para fora tudo o que lhe aflige, com um sorriso, um abraço ou com o ato de acompanhar, ter paciência e aconselhar tendo-se as leis Divinas como alicerce e guia.
                        Felizmente o povo brasileiro tem calor humano e extremos gestos de humildade, basta pois observar nos jornais televisivos pessoas carentes pedindo alimentos, roupas, enxovais para bebês que estão por chegar e sequer possuem um cueiro, uma fraldinha e dias depois estarem com suas pequenas casas cheias de doações.
                        Mas é importante destacar que a verdadeira caridade vem do fundo do coração, de um desejo da alma e não do ego, ou da necessidade de aparecer diante aos olhos alheios.
                        Praticar condutas desmedidas, sem responsabilidade não é agir de forma caridosa, para gostarmos dos outros, primeiro temos que nos amar, nos respeitar e lembrar que a caridade começa em casa.Repetidas vezes vi pessoas ajudando estranhos e maltratando os pais, achincalhando-os, desprezando-os. Que bondade é essa?!
                        E o que dizer acerca das pessoas que tudo tem e vivem a reclamar? Com certeza afirmo, fazer a caridade é o melhor remédio. Visitar hospitais e enxergar que muitos desses problemas tornam-se insignificantes em vista de velhinhos carentes de atenção em asilos, de órfãos esperançosos em encontrarem um novo lar, de pedintes que estabeleceram seus domicílios embaixo de pontes da cidade, das vítimas dos alagamentos.
                        Praticar o bem traz benefícios para o corpo e a alma, enriquece-nos como seres humanos e nos torna imensos para Jesus. Tornamos pessoas mais conscientes e contribuímos para um mundo sem maldades, sem egoísmo e ambições.
                    </p>
                    <p><b>(Kelly Lisita Peres, advogada, professora universitária, pós-graduada em Direito Civil, Penal, Processo Penal e Docência Universitária)</b></p>
                </div>
            </div>
            <div class="col-sm-4">
                <link rel="stylesheet" type="text/css" href="Scripts/estilo.css">
                <div class="jumbotron" style="background-image: url('Imagens/bird_white.png'); color: white">
                    <asp:Label Text="" ID="lblResultado" runat="server" style="color: red"></asp:Label><br /><br />
                    
                        <asp:RadioButton ID="radiodoador" GroupName="formlogin" runat="server" Checked="true" />
                        <label > Doador </label><br />
                        <asp:RadioButton ID="radioinstituicao" GroupName="formlogin" runat="server" />
                        <label > Instuição </label>
                    <br/><br/>
                    <b>Email:</b>
                    <br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Digite o email:" style="color: black" />
                    <br />
                    <asp:RequiredFieldValidator ID="validaemail" runat="server" ErrorMessage="Informe um email" ControlToValidate ="txtEmail" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/>
                    <b>Senha:</b>
                    <br/>
                    <asp:TextBox ID="txtSenha" runat="server" placeholder="Digite a senha:" TextMode ="Password" style="color: black" />
                    <br />
                    <asp:RequiredFieldValidator ID="validasenha" runat="server" ErrorMessage="Informe uma senha" ControlToValidate ="txtSenha" ForeColor ="Red" Display ="Dynamic"></asp:RequiredFieldValidator> <br/><br/>
                    <asp:Button runat="server" Text="Enviar" class="btn btn-success" OnClick="Unnamed1_Click"/>                      
                    <br/>
                     
                    <br/>
                    <br/>
                </div>

                <div class="col-sm-4">
                    <img src="Imagens/natal_sem_fome.jpg" alt="Smiley face" width="390%">
                </div>

            </div>
        </div>
    </div>
</body></html>

</asp:Content>
