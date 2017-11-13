<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaDenuncia.aspx.cs" Inherits="Condominio.Web.Pages.Sindico.Denuncia.ConsultaDenuncia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script src="<%=ResolveClientUrl("~/Scripts/bootstrap-pagination/bs.pagination.min.js")%>"></script>
    
    <script>
        var txtDataInicio = "#<%=txtDataInicio.ClientID%>";
        var txtDataFim = "#<%=txtDataFim.ClientID%>";
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="True"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-md-12 well formulario">
                        <fieldset>
                            <legend><b>Consultar</b> Denúncias</legend>
                        </fieldset>
                        <div class="row">
                            <div class="col-md-8">
                                <div class="col-md-5">
                                    <asp:Label runat="server" for="txtDataInicio" class="control-label"><b>Data Início: </b></asp:Label>
                                    <asp:TextBox runat="server" ID="txtDataInicio" CssClass="form-control campo-data" placeholder="00/00/00000"></asp:TextBox>
                                </div>
                                <div  class="col-md-5">
                                    <asp:Label runat="server" for="txtDataFim" class="control-label"><b>Data Fim: </b></asp:Label>
                                    <asp:TextBox runat="server" ID="txtDataFim" CssClass="form-control campo-data" placeholder="00/00/00000"></asp:TextBox>
                                </div>

                                <div class="col-md-4" style="margin-top: 15px">
                                    <asp:LinkButton runat="server" ID="lkbPesquisar" OnClick="lkbPesquisar_OnClick" Text="<span class='btn-label'><i class='glyphicon glyphicon-search'></i></span><b>Pesquisar</b>"
                                                    CssClass="btn btn-labeled btn-primary"></asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="table-responsive col-xs-12 col-sm-12 col-md-12">
                                <asp:UpdatePanel runat="server">
                                    <ContentTemplate>
                                        <asp:GridView ID="grvDenuncia" runat="server" DataKeyNames="IdDenuncia" CssClass="table table-responsive bs-pagination"
                                                      PagerSettings-Mode="NumericFirstLast" PagerSettings-FirstPageText="Primeira" PagerSettings-LastPageText="Última"
                                                      GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnPageIndexChanging="grvDenuncia_OnPageIndexChanging">
                                            <Columns>
                                                <asp:BoundField DataField="IdDenuncia" HeaderText="Código">
                                                    <ItemStyle CssClass="HideColumnGridView"></ItemStyle>
                                                    <HeaderStyle CssClass="HideColumnGridView"></HeaderStyle>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                                <asp:BoundField DataField="Celular" HeaderText="Celular" />
                                                <asp:BoundField DataField="Email" HeaderText="Email"/>
                                                <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
                                                <asp:BoundField DataField="DataDenuncia" HeaderText="Data da Denúncia" DataFormatString="{0:dd/MM/yyyy}"/>
                                                <asp:BoundField DataField="Ativo" HeaderText="Ativo" />

                                                <asp:TemplateField>
                                                    <ItemStyle></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:LinkButton runat="server" ID="lbtnDetalhe" title="Visualizar Anexo de Imagem" OnClick="lbtnDetalhe_OnClick" 
                                                            Text="<span class='btn-label-'><i class='fa fa-picture-o' aria-hidden='true'></i></span>"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>

                                            <EmptyDataTemplate>
                                                <div>
                                                    <div class="row">
                                                        <h2 class="text-muted"><i><b>Nenhum</b> resultado</i></h2>
                                                    </div>
                                                </div>
                                            </EmptyDataTemplate>
                                        </asp:GridView>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </div>
                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="false" DisplayAfter="1">
                            <ProgressTemplate>
                                <div class="text-muted navbar-fixed-bottom" style="margin-bottom: 50px; margin-left: 10px">
                                    <h2><i class="fa fa-cog fa-spin fa-2x"></i>&nbsp; Processando ...</h2>
                                </div>
                            </ProgressTemplate>
                        </asp:UpdateProgress>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
