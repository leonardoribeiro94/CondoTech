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
                                <b>Reservar</b> <span id="spanNomeDaArea" runat="server"></span> &nbsp; <span class="hidden" runat="server" ID="hdnIdAreaDeLazer"></span>
                            </legend>
                            
                            <div class="row">
                                <div class="col-md-5">
                                    
                                </div>
                            </div>

                        </fieldset>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
