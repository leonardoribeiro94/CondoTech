using System;
using System.Text.RegularExpressions;
using Condominio.Model.Enum;

namespace Condominio.Model
{
    public class Fornecedor : Entidade
    {

        #region Propriedades

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Descricao { get; set; }
        public EntidadeAtiva EntidadeAtivo { get; set; }

        #endregion

        #region Metodos
        public void ValidaDados()
        {
            Nome = Nome.ToUpper().Trim();
            Telefone = Telefone.Replace("(", "").Replace(")", "").Replace("-", "");
            TelefoneCelular = TelefoneCelular.Replace("(", "").Replace(")", "").Replace("-", "");
            Cnpj = Cnpj.Replace("/", "").Replace("-", "");

            if (Nome.Length < 3)
            {
                throw new Exception("Nome informado inválido!");
            }
            if (Telefone.Length < 10)
            {
                throw new Exception("Telefone informado inválido!");
            }
            if (TelefoneCelular.Length < 11)
            {
                throw new Exception("Telefone Celular informado inválido!");
            }

            var opcaoCnpj = ValidaCnpj(Cnpj);
            var opcaoEmail = ValidaEmail(Email);

            if (opcaoCnpj.Equals(false))
            {
                throw new Exception("O CNPJ informado inválido!");
            }

            if (opcaoEmail.Equals(false))
            {
                throw new Exception("O E-mail informado inválido!");
            }
        }

        private bool ValidaCnpj(string cnpj)
        {
            var multiplicador1 = new[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            var tempCnpj = cnpj.Substring(0, 12);
            var soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            var resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            var digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto;
            return cnpj.EndsWith(digito);
        }

        private bool ValidaEmail(string email)
        {
            return
            Regex.IsMatch(email,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);

        }
        #endregion
    }
}
