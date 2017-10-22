<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirFuncionario.aspx.cs" Inherits="Condominio.Web.Pages.Sindico.InserirFuncionario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
   <script src="<%=ResolveClientUrl("~/Scripts/pages/sindico/InserirFuncionario/funcionario-Inserir-mask.js")%>"></script>
   
    <script>
        var txtNome = "#<%=txtNome.ClientID%>";
        var txtDataNascimento = "#<%=txtDataNascimento.ClientID%>";
        var txtTelefone = "#<%=txtTelefone.ClientID%>";
        var txtCelular = "#<%=txtCelular.ClientID%>";
        var txtEmail = "#<%=txtEmail.ClientID%>";
        var txtCpf   = "#<%=txtCpf.ClientID%>";
        var ddlCargo = "#<%=ddlCargo.ClientID%>";
    </script>
    
     
    
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
                                <asp:LinkButton runat="server" ID="lkbVoltar"
                                    Text="<span class='btn-label'><i class='fa fa-arrow-left' aria-hidden='true'></i></span><b>Voltar</b>" CssClass="btn btn-default"></asp:LinkButton>
                                <b>Inserir</b> Funcionário
                            </legend>
                        </fieldset>

                        <div class="row">
                            <div class=" col-md-4" id="Nome">
                                <asp:Label runat="server"><b>Nome</b></asp:Label>
                                <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" placeholder="Nome do Laboratório"></asp:TextBox>
                            </div>

                            <div class="col-md-4" id="dataNascimento">
                                <asp:Label runat="server"><b>Data de Nascimento</b></asp:Label>
                                <asp:TextBox runat="server" ID="txtDataNascimento" CssClass="form-control" placeholder="00/00/0000"></asp:TextBox>
                            </div>

                            <div class="col-md-4" id="telefone">
                                <asp:Label runat="server"><b>Telefone</b></asp:Label>
                                <asp:TextBox runat="server" ID="txtTelefone" placeholder="(00)000000000" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="col-md-4" id="celular">
                                <asp:Label runat="server"><b>Celular</b></asp:Label>
                                <asp:TextBox runat="server" ID="txtCelular" placeholder="(00)000000000" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="col-md-4" id="email">
                                <asp:Label runat="server"><b>email</b></asp:Label>
                                <asp:TextBox runat="server" ID="txtEmail" placeholder="exemplo@outlook.com" CssClass="form-control"></asp:TextBox>
                            </div>
                            
                            <div class="col-md-4" id="cpf">
                                <asp:Label runat="server"><b>CPF</b></asp:Label>
                                <asp:TextBox runat="server" ID="txtCpf"  placeholder="000000000-00" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="col-md-4" id="cargo">
                                <asp:Label runat="server"><b>Cargo</b></asp:Label>
                                <asp:DropDownList runat="server" ID="ddlCargo" CssClass="form-control" />
                            </div>

                            <div class="col-xs-12 col-md-5 botao-margin-top">
                                <asp:LinkButton runat="server" ID="btnLaboratorioCadastrar" OnClientClick="fn_LaboratorioFieldValidate(); return false;"><span class="btn-label"><i class="fa fa-plus"></i></span><b>&nbsp;Cadastrar</b></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
