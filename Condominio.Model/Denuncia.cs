using Condominio.Model.Enum;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Condominio.Model
{
    public class Denuncia : Entidade
    {
        #region Propriedades

        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public byte[] Imagem { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDenuncia { get; set; }
        public EntidadeAtiva Ativo { get; set; }
        public bool Anonimo { get; }

        #endregion

        #region Metodos
        public void ValidaDados()
        {
            Descricao = Descricao.ToUpper();

            Celular = string.IsNullOrEmpty(Celular) ? null : Celular.Replace("(", "").Replace(")", "")
                .Replace("-", "").Replace(" ", "");

            if (Descricao.Length < 5)
            {
                throw new Exception("A quantidade de caracteres informados na descrição é inválida!");
            }

        }

        private bool ValidaEmail(string email)
        {
            return
                Regex.IsMatch(email,
                    @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                    RegexOptions.IgnoreCase);

        }

        public void ValidaExtensaoDoAnexo(string nomeDoArquivo)
        {
            string[] extensoesValidas = { ".jpg", ".png" };

            if (!extensoesValidas.Contains(nomeDoArquivo))
                throw new Exception("Anexo inserido inválido, insira formatos png e jpg");
        }
        #endregion
    }
}
