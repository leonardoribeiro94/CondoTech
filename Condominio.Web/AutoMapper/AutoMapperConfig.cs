using AutoMapper;
using Condominio.Model;
using Condominio.Model.QueryModel;
using Condominio.Web.ViewModels.Funcionario;

namespace Condominio.Web.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(configuration =>
            {
                configuration.CreateMap<Funcionario, FuncionarioViewModel>();
                configuration.CreateMap<ObterFuncionario, FuncionarioViewModel>();
            });
        }
    }
}