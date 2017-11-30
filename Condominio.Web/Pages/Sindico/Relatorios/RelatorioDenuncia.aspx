<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RelatorioDenuncia.aspx.cs" Inherits="Condominio.Web.Pages.Sindico.Relatorios.RelatorioDenuncia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script src="<%=ResolveClientUrl("~/Scripts/pages/sindico/relatorio/relatorio-denuncia.js")%>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="true"></asp:ScriptManager>
    <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <ContentTemplate>

            <div class="container">
                <div class="row">
                    <div class="col-md-10 well formulario">
                        <fieldset>
                            <legend>
                                <b>Relatório</b> Denúncias
                            </legend>
                        </fieldset>
                        
                        <div class="row">
                            <div class="col-md-5">
                                <asp:Label runat="server"><b>Data Inicial</b></asp:Label>
                                <asp:TextBox runat="server" CssClass="form-control calendario-generico" ID="txtDataInicio" placeholder="dd/mm/aaaa"></asp:TextBox>
                            </div>
                            <div class="col-md-5">
                                <asp:Label runat="server"><b>Data Final</b></asp:Label>
                                <asp:TextBox runat="server" CssClass="form-control calendario-generico" ID="txtDataFinal" placeholder="dd/mm/aaaa"></asp:TextBox>
                            </div>
                            <div class="col-md-4" style="margin-top: 15px">
                                <asp:LinkButton runat="server" ID="lkbGeraRelatorio" OnClick="lkbGeraRelatorio_OnClick" Text="<span class='btn-label'><i class='fa fa-line-chart'></i></span><b>&nbsp;Gerar Relatorio</b>"
                                                CssClass="btn btn-primary"></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="lkbGeraRelatorio"/>
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
