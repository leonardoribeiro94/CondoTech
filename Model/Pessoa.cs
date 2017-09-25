using Model.Componentes;
using Model.Enum;
using System;
using System.Text.RegularExpressions;

namespace Model
{
    public abstract class Pessoa : Entidade
    {

        #region Propriedades

        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public EntidadeAtiva EntidadeAtiva { get; set; }
        #endregion


        #region Metodos
        public void ValidaDados()
        {
            Nome = Nome.ToUpper().Trim();

            Telefone = Telefone.Replace("(", "").Replace(")", "")
                .Replace("-", "").Replace(" ", "");

            Celular = Celular.Replace("(", "").Replace(")", "")
                .Replace("-", "").Replace(" ", "");

            Cpf = Cpf.Replace("-", "").Replace(".", "");

            if (Nome.Length < 3)
            {
                throw new Exception(MensagensDeValidacao.Nome);
            }

            var boolCpf = ValidaCpf(Cpf);

            if (boolCpf == false)
            {
                throw new Exception(MensagensDeValidacao.Cpf);
            }

            var boolEmail = ValidaEmail(Email);

            if (boolEmail == false)
            {
                throw new Exception(MensagensDeValidacao.Email);
            }

            if (DataDeNascimento.Year > DateTime.Now.Year)
            {
                throw new Exception("Data de Nascimento inválida!");
            }

            if (string.IsNullOrEmpty(Telefone)
                && string.IsNullOrEmpty(Celular))
            {
                throw new Exception("Informe ao menos um telefone para contato!");
            }
        }

        public bool ValidaCpf(string cpf)
        {
            if (cpf.Equals("00000000000") || cpf.Equals("11111111111") ||
                cpf.Equals("22222222222") || cpf.Equals("33333333333") ||
                cpf.Equals("44444444444") || cpf.Equals("55555555555") ||
                cpf.Equals("66666666666") || cpf.Equals("77777777777") ||
                cpf.Equals("88888888888") || cpf.Equals("99999999999") ||
                cpf.Length != 11)
                return (false);

            var multiplicador1 = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            var tempCpf = cpf.Substring(0, 9);
            var soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            var resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            var digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto;
            return cpf.EndsWith(digito);
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
