using Condominio.Model;
using Condominio.Model.Enum;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Condominio.Web.ViewModels.Funcionario
{
    public class FuncionarioViewModel
    {
        [DisplayName("Código")]
        public int IdFuncionario { get; set; }
        public int IdCargo { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(70, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Preencha o Campo Telefone")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string Telefone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Preencha o Campo Celular")]
        [MinLength(11, ErrorMessage = "Mínimo {0} caracteres")]
        public string Celular { get; set; }


        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Preencha o Campo E-mail")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string Email { get; set; }


        [DisplayName("CPF")]
        [Required(ErrorMessage = "Preencha o Campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo {0} caracteres")]
        public string Cpf { get; set; }

        public EntidadeAtiva Ativo { get; set; }
        public IEnumerable<Cargo> Cargos { get; set; }
    }
}