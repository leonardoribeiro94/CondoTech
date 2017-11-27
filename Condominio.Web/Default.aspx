<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Condominio.Web.Default" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <link href="<%=ResolveClientUrl("Content/default.css")%>" rel="stylesheet" />
    <script src="<%=ResolveClientUrl("~/Scripts/pages/default.js")%>"></script>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="true"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <body id="myPage" data-spy="scroll" data-target=".navbar" data-offset="60">

                <nav class="navbar navbar-default navbar-fixed-top">
                    <div class="container">
                        <div class="navbar-header">
                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                            </button>
                            <a class="navbar-brand" href="#myPage"><strong>Condotech</strong></a>
                        </div>
                        <div class="collapse navbar-collapse" id="myNavbar">
                            <ul class="nav navbar-nav navbar-right">
                                <li><a href="#about">Sobre</a></li>
                                <li><a href="#services">Serviços</a></li>
                                <li><a href="#portfolio">Clientes</a></li>
                            </ul>
                        </div>
                    </div>
                </nav>

                <div class="jumbotron text-center">
                    <h1>Condotech</h1>
                    <p>Especializados em conforto e tecnologia para condomínios</p>

                    <div class="col-md-12">
                        <button type="button" data-toggle="modal" data-target="#modalLogin" class="btn btn-danger">Área Particular</button>
                    </div>
                </div>

                <!-- Container (About Section) -->
                <div id="about" class="container-fluid">
                    <div class="row">
                        <div class="col-sm-8">
                            <h2>Sobre o CondoTech</h2>
                            <br>
                            <h4>Com o Condotech você não apenas gerencia seu condomínio, mas sim, cria agilidade no serviço e comodidade para verificar e ficar por dentro de todas as novidades de onde mora!.</h4>
                            <br>
                            <p>
                                Nós do Condotech nos empenhamos, para oferecer uma experiência completa de recursos e informação para você que se interessa sobre vida em condomínio.
                                E foi pensando nisso que demos mais um passo para facilitar a gestão de condomínios: criamos o CondoTech Web. Essa ferramenta do ajuda o dia a dia do seu condomínio a ser mais ágil, com mais comunicação e com mais sentimento de vizinhança.
                                O CondoTech web foi feito para você, com muito empenho, pelas mais competentes pessoas. Aproveite!!
                            </p>
                            <br>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-signal logo"></span>
                        </div>
                    </div>
                </div>

                <div class="container-fluid bg-grey">
                    <div class="row">
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-globe logo slideanim"></span>
                        </div>
                        <div class="col-sm-8">
                            <h2>Nóssos valores</h2>
                            <br>
                            <h4><strong>Missão:</strong> Nossa missão é proporcionar aos nossos clientes a melhor experiência de gererenciamento de condominios automatizado.</h4>
                            <br>
                            <p>
                                <strong>Visão:</strong> Nossa visão é ajudar a todos que realmente se importam com a informação de seu lar a mantê-la segura e protegida.
                            </p>
                        </div>
                    </div>
                </div>

                <!-- Container (Services Section) -->
                <div id="services" class="container-fluid text-center">
                    <h2>Serviços</h2>
                    <h4>O que nós oferecemos</h4>
                    <br>
                    <div class="row slideanim">
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-lock logo-small"></span>
                            <h4>Segurança</h4>
                            <p>Somente usuários previamente aprovados têm acesso protegido ao site do condomínio.</p>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-bullhorn logo-small"></span>
                            <h4>Informativos</h4>
                            <p>Mantenha todos os moradores informados sobre o que acontece no condomínio</p>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-calendar logo-small"></span>
                            <h4>Eventos</h4>
                            <p>Adicione eventos, crie e reserve facilmente espaços para salão de festas, quadras, etc.</p>
                        </div>
                    </div>
                    <br>
                    <br>
                    <div class="row slideanim">
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-file logo-small"></span>
                            <h4>Documentos</h4>
                            <p>Organize e disponibilize documentos como Regimento Interno, Convenção, Atas, etc.</p>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-user logo-small"></span>
                            <h4>Funcionários</h4>
                            <p>Cadastre os funcionários do condomínio e informe cargos e permissões de acessos...</p>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-exclamation-sign logo-small"></span>
                            <h4 style="color: #303030;">Denúncias</h4>
                            <p>Tenha um registro de todas as denúncias, que acontecem em seu condomínio...</p>
                        </div>
                    </div>
                </div>

                <!-- Container (Portfolio Section) -->
                <div id="portfolio" class="container-fluid text-center bg-grey">
                    <h2>O que nossos clientes dizem</h2>
                    <div id="myCarousel" class="carousel slide text-center" data-ride="carousel">
                        <!-- Indicators -->
                        <ol class="carousel-indicators">
                            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                            <li data-target="#myCarousel" data-slide-to="1"></li>
                            <li data-target="#myCarousel" data-slide-to="2"></li>
                        </ol>

                        <!-- Wrapper for slides -->
                        <div class="carousel-inner" role="listbox">
                            <div class="item active">
                                <h4>"Este sistema é o melhor. Estou muito feliz com os resultados!"<br>
                                    <span>Antônio Roe, Vice Presidente empresarial, Condominio Família</span></h4>
                            </div>
                            <div class="item">
                                <h4>"Atende realmente o que preciso... Fácil e simples!!"<br>
                                    <span>John Cena, Síndico, WWE Condomínio Esportivo</span></h4>
                            </div>
                            <div class="item">
                                <h4>"Estou realmente feliz com o sistema, os moradores acham demais!"<br>
                                    <span>Ching Ling, Síndico, Condomínio Liberdade</span></h4>
                            </div>
                        </div>

                        <!-- Left and right controls -->
                        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                        </a>
                    </div>
                </div>
            </body>
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="modal fade" style="margin-top: 30px" id="modalLogin" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header btn-primary">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                    <h3><i class="fa fa-user-circle-o" aria-hidden="true"></i>&nbsp; 
                                <b>Login</b></h3>

                </div>
                <div class="modal-body">
                    <form>
                        <div class="row">
                            <div class="col-md-5">
                                <label class="control-label"><b>Login</b>:</label>
                                <asp:TextBox CssClass="form-control" ID="txtLogin" runat="server" />
                            </div>
                            <div class="col-md-5">
                                <label class="control-label">senha:</label>
                                <asp:TextBox CssClass="form-control" type="password" ID="txtSenha" runat="server" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-8">
                                <asp:Button runat="server" CssClass="btn btn-primary" OnClick="btnLogin_OnClick" Text="Login" />
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
