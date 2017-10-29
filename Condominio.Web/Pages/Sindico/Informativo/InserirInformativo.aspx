<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirInformativo.aspx.cs" Inherits="Condominio.Web.Pages.Sindico.Informativo.InserirInformativo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="True"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-md-10 well formulario">
                        <fieldset>
                            <legend>
                                <asp:LinkButton runat="server" ID="lkbVoltar" OnClick="LkbVoltar_Click" Text="<span class='btn-label'><i class='fa fa-arrow-left' aria-hidden='true'></i></span><b>Voltar</b>" CssClass="btn btn-default"></asp:LinkButton>
                                <b>Inserir</b> Informativo
                            </legend>
                        </fieldset>

                        <div class="row">
                        </div>

                        <div class="row">
                            <div class="col-md-4" id="Titulo">
                                <asp:Label runat="server"><b>Titulo</b></asp:Label>
                                <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control" onkeyup="verificaCampo(txtTitulo, '#Titulo', 3);" placeholder="Titulo do informativo"></asp:TextBox>
                            </div>

                            <div id="upload-documento" class="col-md-5" style="margin-top: 18px">
                                <label class="btn btn-info" for="myFileUpload">
                                    <i class="fa fa-cloud-upload" aria-hidden="true"></i>&nbsp; Upload de Arquivo
                                    <input type="file" id="myFileUpload" class="hidden" onchange="$('#upload-file-info').html(this.files[0].name)" />
                                </label>
                                <label class='label label-info' id="upload-file-info"></label>
                            </div>
                        </div>

                        <div class="row">
                            <div id="descricao-informativo" class="col-md-5">
                                <label class="control-label"><b>Observação:</b></label>
                                <textarea cols="2" runat="server" id="txtObservacao" style="max-width: 150%" maxlength="500" class="form-control" placeholder="Observações adicionais sobre o infomativo"></textarea>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-10">
                                <asp:Button runat="server" CssClass="btn btn-primary" Text="Inserir"/>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
