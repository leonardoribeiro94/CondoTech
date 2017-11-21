<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarReservasAreaDeLazer.aspx.cs" Inherits="Condominio.Web.Pages.Sindico.ReservasAreaDeLazer.ConsultarReservasAreaDeLazer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="True"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-md-12 well formulario">
                        <fieldset>
                            <legend><b>Consultar</b> Reservas Area de Lazer</legend>
                        </fieldset>
                        <div class="row">
                            <div class="col-md-8">
                                <div class="col-md-5">
                                    <asp:Label runat="server" for="txtCodigoReserva" class="control-label"><b>Código da Reserva: </b></asp:Label>
                                    <asp:TextBox runat="server" ID="txtCodigoReserva" CssClass="form-control" placeholder="Insira o cóodigo da reserva"></asp:TextBox>
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
                                        <asp:GridView ID="grvReserva" runat="server" CssClass="table table-responsive bs-pagination"
                                            PagerSettings-Mode="NumericFirstLast" PagerSettings-FirstPageText="Primeira" PagerSettings-LastPageText="Última"
                                            GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnPageIndexChanging="grvReserva_OnPageIndexChanging">
                                            <Columns>
                                                <asp:BoundField DataField="IdReserva" HeaderText="Código Reserva"/>
                                                <asp:BoundField DataField="NomeMorador" HeaderText="Morador" />
                                                <asp:BoundField DataField="Cpf" HeaderText="CPF" />
                                                <asp:BoundField DataField="NomeAreaDeLazer" HeaderText="Area de Lazer"/>
                                                <asp:BoundField DataField="DataReserva" HeaderText="Data Reserva" DataFormatString="{0:dd/MM/yyyy}"/>
                                                <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
                                                
                                                <asp:TemplateField>
                                                    <ItemStyle Width="20px"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:LinkButton runat="server" ID="lbtnDetalhes" title="Editar" OnClick="lbtnDetalhes_OnClick" Text="<span class='btn-label-'><i class='fa fa-pencil' aria-hidden='true'></i></i></span>"></asp:LinkButton>
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
            
            <!-- Modal -->
            <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Modal Header</h4>
                        </div>
                        <div class="modal-body">
                            <p>Some text in the modal.</p>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </div>
                    </div>
      
                </div>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
