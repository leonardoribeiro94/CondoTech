<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Condominio.Web.Default" %>

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
                            <a class="navbar-brand" href="#myPage">Logo</a>
                        </div>
                        <div class="collapse navbar-collapse" id="myNavbar">
                            <ul class="nav navbar-nav navbar-right">
                                <li><a href="#about">Sobre</a></li>
                                <li><a href="#services">Serviços</a></li>
                                <li><a href="#portfolio">Lazer</a></li>
                            </ul>
                        </div>
                    </div>
                </nav>

                <div class="jumbotron text-center">
                    <h1>CondoFamily</h1>
                    <p>Especializados em conforto para família</p>

                    <div class="col-md-12">
                        <button type="button" data-toggle="modal" data-target="#modalLogin" class="btn btn-danger">Área Particular</button>
                    </div>
                </div>

                <!-- Container (About Section) -->
                <div id="about" class="container-fluid">
                    <div class="row">
                        <div class="col-sm-8">
                            <h2>Sobre a compania</h2>
                            <br>
                            <h4>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</h4>
                            <br>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                            <br>
                            <button class="btn btn-default btn-lg">Get in Touch</button>
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
                            <h2>Our Values</h2>
                            <br>
                            <h4><strong>Missão:</strong> Nossa missão lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</h4>
                            <br>
                            <p>
                                <strong>Visão:</strong> Nossa visão Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
      Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
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
                            <span class="glyphicon glyphicon-off logo-small"></span>
                            <h4>Força</h4>
                            <p>Lorem ipsum dolor sit amet..</p>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-heart logo-small"></span>
                            <h4>Amor</h4>
                            <p>Lorem ipsum dolor sit amet..</p>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-lock logo-small"></span>
                            <h4>Trabalho duro</h4>
                            <p>Lorem ipsum dolor sit amet..</p>
                        </div>
                    </div>
                    <br>
                    <br>
                    <div class="row slideanim">
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-leaf logo-small"></span>
                            <h4>GREEN</h4>
                            <p>Lorem ipsum dolor sit amet..</p>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-certificate logo-small"></span>
                            <h4>CERTIFIED</h4>
                            <p>Lorem ipsum dolor sit amet..</p>
                        </div>
                        <div class="col-sm-4">
                            <span class="glyphicon glyphicon-wrench logo-small"></span>
                            <h4 style="color: #303030;">HARD WORK</h4>
                            <p>Lorem ipsum dolor sit amet..</p>
                        </div>
                    </div>
                </div>

                <!-- Container (Portfolio Section) -->
                <div id="portfolio" class="container-fluid text-center bg-grey">
                    <h2>Portfolio</h2>
                    <br>
                    <h4>Lazer</h4>
                    <div class="row text-center slideanim">
                        <div class="col-sm-4">
                            <div class="thumbnail">
                                <img src="paris.jpg" alt="Paris" width="400" height="300">
                                <p><strong>Paris</strong></p>
                                <p>Yes, we built Paris</p>
                            </div>
                        </div>
                        <div class="col-sm-4">
                            <div class="thumbnail">
                                <img src="newyork.jpg" alt="New York" width="400" height="300">
                                <p><strong>New York</strong></p>
                                <p>We built New York</p>
                            </div>
                        </div>
                        <div class="col-sm-4">
                            <div class="thumbnail">
                                <img src="sanfran.jpg" alt="San Francisco" width="400" height="300">
                                <p><strong>San Francisco</strong></p>
                                <p>Yes, San Fran is ours</p>
                            </div>
                        </div>
                    </div>
                    <br>

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
                                <h4>"This company is the best. I am so happy with the result!"<br>
                                    <span>Michael Roe, Vice President, Comment Box</span></h4>
                            </div>
                            <div class="item">
                                <h4>"One word... WOW!!"<br>
                                    <span>John Doe, Salesman, Rep Inc</span></h4>
                            </div>
                            <div class="item">
                                <h4>"Could I... BE any more happy with this company?"<br>
                                    <span>Chandler Bing, Actor, FriendsAlot</span></h4>
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
                                <asp:TextBox CssClass="form-control" ID="txtLogin" runat="server"/>
                            </div>
                            <div class="col-md-5">
                                <label class="control-label">senha:</label>
                                <asp:TextBox CssClass="form-control" type="password" ID="txtSenha" runat="server"/>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-8">
                                <button type="button" class="btn btn-primary"><i class="fa fa-sign-in" aria-hidden="true"></i>&nbsp; Login</button>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-5">
                                <a href="#">Esqueceu sua senha?</a>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    
    <asp:Button runat="server" ID="btnLogin" OnClick="btnLogin_OnClick"/>
</asp:Content>
