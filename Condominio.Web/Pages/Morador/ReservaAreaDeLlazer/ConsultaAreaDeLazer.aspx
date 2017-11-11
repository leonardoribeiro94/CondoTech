<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaAreaDeLazer.aspx.cs" Inherits="Condominio.Web.Pages.Morador.ReservaAreaDeLlazer.ConsultaAreaDeLazer" %>

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
                            <legend><b>Reserva</b> Área de Lazer;
                            </legend>
                        </fieldset>
                        <div class="row">
                            <div class="col-md-8">
                                <div class="col-md-5">
                                    <asp:Label runat="server" for="txtNomeAreaDeLazer" class="control-label"><b>Nome: </b></asp:Label>
                                    <asp:TextBox runat="server" ID="txtNomeAreaDeLazer" CssClass="form-control" placeholder="Insira o nome da area de lazer desejado"></asp:TextBox>
                                </div>

                                <div class="col-md-4" style="margin-top: 15px">
                                    <asp:LinkButton runat="server" ID="lkbPesquisar" OnClick="lkbPesquisar_OnClick" Text="<span class='btn-label'><i class='glyphicon glyphicon-search'></i></span><b>Pesquisar</b>"
                                        CssClass="btn btn-labeled btn-primary"></asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <br />
                        <ul class="nav nav-pills" id="minhaTab">
                            <li class="active"><a href="#gridAreasDeLazer" data-toggle="tab"><strong>Áreas de lazer</strong></a></li>
                            <li><a href="#gridAreasDeLazerReservadas" data-toggle="tab"><strong>Minhas reservas</strong></a></li>
                        </ul>
                        <!--GRID AREAS DE LAZER-->
                        <div class="tab-pane fade in active" id="gridAreasDeLazer">
                            <div class="row">
                                <div class="table-responsive col-xs-12 col-sm-12 col-md-12">
                                    <asp:UpdatePanel runat="server">
                                        <ContentTemplate>
                                            <asp:GridView ID="grvAreaDeLazer" runat="server" DataKeyNames="IdAreaDeLazer" CssClass="table table-responsive bs-pagination"
                                                PagerSettings-Mode="NumericFirstLast" PagerSettings-FirstPageText="Primeira" PagerSettings-LastPageText="Última"
                                                GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnPageIndexChanging="grvAreaDeLazer_OnPageIndexChanging">
                                                <Columns>
                                                    <asp:BoundField DataField="IdAreaDeLazer" HeaderText="Código" />
                                                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                                    <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
                                                    <asp:BoundField DataField="Ativo" HeaderText="Ativo" />
                                                    <asp:BoundField DataField="Nome" HeaderText="Informante" />

                                                    <asp:TemplateField>
                                                        <ItemStyle></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:LinkButton runat="server" ID="lblExibeImagem" OnClick="lblExibeImagem_OnClick" title="Imagem da Área de Lazer" Text="<span class='btn-label-'><i class='fa fa-picture-o' aria-hidden='true'></i></span>"></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <asp:TemplateField>
                                                        <ItemStyle></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:LinkButton runat="server" ID="lblSolicitaReserva" OnClick="lblSolicitaReserva_OnClick" title="Solicitar Reserva" Text="<span class='btn-label-'><i class='fa fa-calendar-check-o' aria-hidden='true'></i></span>"></asp:LinkButton>
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
                        </div>

                        <!--GRID AREAS RESERVADAS-->
                        <div class="tab-pane fade" id="gridAreasDeLazerReservadas">
                            <div class="row">
                                <div class="table-responsive col-xs-12 col-sm-12 col-md-12">
                                    <asp:UpdatePanel runat="server">
                                        <ContentTemplate>
                                            <asp:GridView ID="GridAreasDeLazerReservadas" runat="server" DataKeyNames="IdInformativo" CssClass="table table-responsive bs-pagination"
                                                PagerSettings-Mode="NumericFirstLast" PagerSettings-FirstPageText="Primeira" PagerSettings-LastPageText="Última"
                                                GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnPageIndexChanging="GridAreasDeLazerReservadas_OnPageIndexChanging">
                                                <Columns>
                                                    <asp:BoundField DataField="IdAreaDeLazer" HeaderText="Código" />
                                                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                                    <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
                                                    <asp:BoundField DataField="DataSolicitacao" DataFormatString="{0:dd/MM/yyyy}"/>
                                                    <asp:BoundField DataField="Status" HeaderText="Status" />
                                                    
                                                    <asp:TemplateField>
                                                        <ItemStyle></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:LinkButton runat="server" ID="lbtnCancelarAgendamento" title="Cancelar meu pedido" Text="<span class='btn-label-'><i class='fa fa-calendar-times-o' aria-hidden='true'></i>"></asp:LinkButton>
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
