<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirDenuncia.aspx.cs" Inherits="Condominio.Web.Pages.Morador.Denuncia.InserirDenuncia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
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
                            <div id="upload-documento" class="col-md-5 file-upload" style="margin-top: 18px">
                                <asp:Label runat="server" CssClass="btn btn-info" AssociatedControlID="myFileUpload">
                                    <i class="fa fa-cloud-upload" aria-hidden="true"></i>&nbsp; Upload de Imagem
                                    <input type="file" id="myFileUpload" runat="server" class="hidden" onchange="$('#upload-file-info').html(this.files[0].name)" />
                                </asp:Label>
                                <label class="label label-info" id="upload-file-info"></label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-5">
                                <label><b>Nome</b></label>
                                <asp:TextBox runat="server" ID="txtNome" placeholder="Insira o nome" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-5">
                                <label><b>Celular</b></label>
                                <asp:TextBox runat="server" ID="txtCelular" placeholder="(00)000000000" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <label><b>E-mail</b></label>
                                <asp:TextBox runat="server" ID="txtEmail" placeholder="exemploemail@gmail.com" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div id="descricao-informativo" class="col-md-12">
                                <label class="control-label"><b>Observação:</b></label>
                                <textarea cols="2" runat="server" id="txtObservacao" onkeyup="verificaCampo(txtObservacao, '#descricao-informativo', 5);" style="max-width: 150%" maxlength="500" class="form-control" placeholder="Observações adicionais sobre a denúncia"></textarea>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                 <asp:Button runat="server" CssClass="btn btn-primary" Text="Enviar"/>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
