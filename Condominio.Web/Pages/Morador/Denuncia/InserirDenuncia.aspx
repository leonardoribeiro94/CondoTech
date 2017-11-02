<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirDenuncia.aspx.cs" Inherits="Condominio.Web.Pages.Morador.Denuncia.InserirDenuncia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script src="<%=ResolveClientUrl("~/Scripts/pages/morador/denuncia/denuncia-inserir-mask.js")%>"></script>
    <script src="<%=ResolveClientUrl("~/Scripts/pages/morador/denuncia/denuncia-inserir-eventos.js")%>"></script>
    <script src="<%=ResolveClientUrl("~/Scripts/pages/morador/denuncia/denuncia-inserir-validacao.js")%>"></script>
    <script>
        var txtNome = "#<%=txtNome.ClientID%>";
        var ckbAnonimo = "#<%=ckbAnonimo.ClientID%>";
        var txtCelular = "#<%=txtCelular.ClientID%>";
        var txtEmail = "#<%=txtEmail.ClientID%>";
        var txtObservacao = "#<%=txtObservacao.ClientID%>";
        var btnEnviarDenuncia = "#<%=btnEnviarDenuncia.ClientID%>";
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="True"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-md-9 well formulario">
                        <fieldset>
                            <legend><b>Inserir</b> &nbsp;Denúncia &nbsp;
                            </legend>
                        </fieldset>

                        <div class="row">
                            <div class="col-md-5">
                                <asp:CheckBox runat="server" Text="Anônimo" ID="ckbAnonimo" />
                            </div>
                        </div>
                        
                        <div class="row">
                            <div id="upload-documento" class="col-md-5 file-upload">
                                <asp:Label runat="server" CssClass="btn btn-info" AssociatedControlID="myFileUpload">
                                    <i class="fa fa-cloud-upload" aria-hidden="true"></i>&nbsp; Upload de Imagem
                                    <input type="file" id="myFileUpload" runat="server" accept="image/jpg, image/png"  class="hidden" onchange="$('#upload-file-info').html(this.files[0].name)" />
                                </asp:Label>
                                <label class="label label-info" id="upload-file-info"></label>
                            </div>
                        </div>

                        <div id="div-toogle">
                            <div class="row">
                                <div class="col-md-5">
                                    <div id="nome">
                                        <label class="control-label"><b>Nome</b></label>
                                        <asp:TextBox runat="server" ID="txtNome" onkeyup="verificaCampo(txtNome, '#nome', 5);" placeholder="Insira o nome" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-5">
                                    <div id="celular">
                                        <label class="control-label"><b>Celular</b></label>
                                        <asp:TextBox runat="server" ID="txtCelular" onkeyup="verificaCampo(txtCelular, '#celular', 11);" placeholder="(00)000000000" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12 control-label">
                                    <div id="email">
                                        <label class="control-label"><b>E-mail</b></label>
                                        <asp:TextBox runat="server" ID="txtEmail" onkeyup="verificaCampo(txtEmail, '#email', 5);" placeholder="exemploemail@gmail.com" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class="row">
                            <div id="descricao-informativo" class="col-md-12">
                                <label class="control-label"><b>Observação:</b></label>
                                <textarea cols="2" runat="server" id="txtObservacao" onkeyup="verificaCampo(txtObservacao, '#descricao-informativo', 8);" style="max-width: 150%" maxlength="500" class="form-control" placeholder="Observações adicionais sobre a denúncia"></textarea>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <asp:Button runat="server" ID="btnInserir" OnClientClick="confirmarEnvio(); return false;" CssClass="btn btn-primary" Text="Enviar" />
                            </div>

                            <div class="col-md-4">
                                <asp:Button runat="server" ID="btnEnviarDenuncia" OnClick="btnInserir_OnClick" CssClass="hidden" />
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnEnviarDenuncia" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
