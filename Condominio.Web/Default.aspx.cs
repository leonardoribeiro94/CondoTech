using Condominio.Controllers;
using Condominio.Model;
using Condominio.Web.Components;
using System;
using System.Web.UI;

namespace Condominio.Web
{
    public partial class Default : Page
    {
        private readonly Mensagens _mensagens;
        private readonly UsuarioFuncionarioControl _funcionarioControl;
        private readonly UsuarioMorador _morador;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}