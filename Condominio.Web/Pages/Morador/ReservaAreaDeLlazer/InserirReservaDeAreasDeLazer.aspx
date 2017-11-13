<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirReservaDeAreasDeLazer.aspx.cs" Inherits="Condominio.Web.Pages.Morador.ReservaAreaDeLlazer.InserirReservaDeAreasDeLazer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="True"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-md-10 formulario">
                        <fieldset>
                            <legend>
                                <asp:LinkButton runat="server" ID="lkbVoltar"
                                    OnClick="lkbVoltar_OnClick" Text="<span class='btn-label'><i class='fa fa-arrow-left' aria-hidden='true'></i></span><b>Voltar</b>" CssClass="btn btn-default"></asp:LinkButton>
                                <b>Reservar</b> <span id="spanNomeDaArea" runat="server"></span>
                            </legend>

                            <div class="row">
                                <div class="col-md-5">
                                    <label class="control-label"><b>Data da Solicitacao</b></label>
                                    <asp:UpdatePanel runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox runat="server" ID="txtDataReserva" CssClass="form-control campo-data" placeholder="dd/mm/aaaa"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>

                                </div>
                            </div>
                            <div class="row">
                                <div id="descricao-informativo" class="col-md-12">
                                    <label class="control-label"><b>Observações:</b></label>
                                    <textarea cols="2" runat="server" id="txtObservacao" onkeyup="verificaCampo(txtObservacao, '#descricao-informativo', 8);" style="max-width: 150%" maxlength="500" class="form-control" placeholder="Observações adicionais sobre a denúncia"></textarea>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <asp:Button runat="server" ID="btnInserir" OnClientClick="confirmarEnvio(); return false;" CssClass="btn btn-primary" Text="Solicitar Reserva" />
                                </div>
                            </div>
                        </fieldset>
                    </div>
                </div>
            </div>

            <asp:Button runat="server" ID="btnSolicitarPedido" OnClick="btnSolicitarPedido_OnClick" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
