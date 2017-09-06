using Model;
using Model.Agregador;
using System.Collections.Generic;

namespace DataAccessLayer.Repositorios.FalsoRepositorio
{
    public class FalsoRep
    {
        #region Moradores

        public ICollection<Morador> SelecionaMoradores()
        {
            var moradores = new List<Morador>
            {
                new Morador {Id = 1, Nome = "Leonardo", Email = "leonardo@hotmail.com"},
                new Morador {Id = 2, Nome = "Marina", Email = "marinacatsexyfuckinghot@gmail.com"},
                new Morador {Id = 3, Nome = "Lucas", Email = "lucas@hotmail.com"},
                new Morador {Id = 4, Nome = "Rodrigo", Email = "rodrigo@gmail.com"},
                new Morador {Id = 5, Nome = "Sheyla", Email = "sheyla@gmail.com"},
                new Morador {Id = 6, Nome = "Carlos", Email = "carlos@hotmail.com"},
                new Morador {Id = 7, Nome = "ludneia", Email = "ludneiachata@yahool.com"},
                new Morador {Id = 8, Nome = "Thaina", Email = "thaynahavenadlc@uol.com"},
                new Morador {Id = 9, Nome = "Gabriel", Email = "gabriel@yahool.com"},
                new Morador {Id = 10, Nome = "Julio", Email = "julionagaita@hotmail.com"}
            };


            return moradores;
        }

        #endregion

        #region Cargos

        public ICollection<Cargo> SelecionaCargos()
        {
            var cargos = new List<Cargo>
            {
                new Cargo {Id = 1, Nome = "Síndico", Descricao = "Administrador do prédio"},
                new Cargo {Id = 2, Nome = "Porteiro", Descricao = "Atua na Portaria do prédio"},
                new Cargo {Id = 3, Nome = "Jardineiro", Descricao = "Atua na Jardim do prédio"},
                new Cargo {Id = 4, Nome = "Zelador", Descricao = "Atua na zeladoria do prédio"},
                new Cargo {Id = 5, Nome = "Eletricista", Descricao = "Atua na manutenção do prédio"},
                new Cargo {Id = 6, Nome = "Bombeiro", Descricao = "Atua na segurança de todo prédio"}
            };


            return cargos;
        }

        #endregion

        #region Funcionarios

        public ICollection<Funcionario> SelecionaFuncionarios()
        {
            var funcionarios = new List<Funcionario>
            {
                new Funcionario {Id = 1, Cargo = new Cargo {Id = 1}, Nome = "Anderson", Email = "anderson@gmail.com"},
                new Funcionario {Id = 2, Cargo = new Cargo {Id = 2}, Nome = "andrew", Email = "andrew@gmail.com"},
                new Funcionario {Id = 3, Cargo = new Cargo {Id = 2}, Nome = "Mathew", Email = "mathew@gmail.com"},
                new Funcionario {Id = 4, Cargo = new Cargo {Id = 3}, Nome = "Jhony", Email = "jhony@gmail.com"},
                new Funcionario {Id = 5, Cargo = new Cargo {Id = 3}, Nome = "Zaky", Email = "zacky@gmail.com"},
                new Funcionario {Id = 6, Cargo = new Cargo {Id = 4}, Nome = "Bryan", Email = "bryan@gmail.com"},
                new Funcionario {Id = 7, Cargo = new Cargo {Id = 4}, Nome = "Jimmy", Email = "jmmy@gmail.com"},
                new Funcionario {Id = 8, Cargo = new Cargo {Id = 5}, Nome = "Brooks", Email = "brooks@gmail.com"},
                new Funcionario {Id = 9, Cargo = new Cargo {Id = 5}, Nome = "Arin", Email = "arin@gmail.com"},
                new Funcionario {Id = 10, Cargo = new Cargo {Id = 6}, Nome = "Myke", Email = "myke@gmail.com"},
                new Funcionario {Id = 11, Cargo = new Cargo {Id = 6}, Nome = "Gerard", Email = "gerard@gmail.com"}
            };

            return funcionarios;
        }

        #endregion

        #region AreaDeLazer

        //public ICollection<AreaDeLazer> AreasdeLazeres()
        //{
        //    var areadeLazer = new List<AreaDeLazer>
        //    {
        //        new AreaDeLazer {Id = 1, Nome = "Churrascaria", Descricao = "Churrascaria do Condomínio", EntidadeAtiva = EntidadeAtiva.Ativo},
        //        new AreaDeLazer {Id = 2, Nome = "Piscina", Descricao = "Piscina do Condomínio", EntidadeAtiva = EntidadeAtiva.Ativo},
        //        new AreaDeLazer {Id = 3, Nome = "Salão de Festas", Descricao = "Salão de Festas do Condomínio", EntidadeAtiva = EntidadeAtiva.Ativo}

        //    };

        //    return areadeLazer;
        //}

        #endregion

        #region ReservaAreaDeLazer

        //public ICollection<ReservaAreaDeLazer> SelecionaReservaDeAreaDeLazers()
        //{
        //    var reservaAreaDeLazer = new List<ReservaAreaDeLazer>
        //    {
        //        new ReservaAreaDeLazer {Id = 3, Morador = new Morador {Id = 1}, AreaDeLazer = new AreaDeLazer {Id = 1}, DisponibilidadeDaAreaDeLazer = DisponibilidadeDaAreaDeLazer.Disponivel},
        //        new ReservaAreaDeLazer {Id = 2, Morador = new Morador {Id = 1}, AreaDeLazer = new AreaDeLazer {Id = 1}, DisponibilidadeDaAreaDeLazer = DisponibilidadeDaAreaDeLazer.Indisponivel}

        //        };
        //    return reservaAreaDeLazer;
        //}

        #endregion

        #region Usuarios

        public ICollection<Usuario> SelecionaUsuarios()
        {
            var usuarios = new List<Usuario>
            {
                //new Usuario { Id = 1, IdEntidade = 1, TipoUsuario = TipoUsuario.Funcionario, EntidadeAtiva = EntidadeAtiva.Ativo},
                //new Usuario { Id = 2, IdEntidade = 1, TipoUsuario = TipoUsuario.Morador, EntidadeAtiva = EntidadeAtiva.Ativo},
                //new Usuario { Id = 3, IdEntidade = 4, TipoUsuario = TipoUsuario.Funcionario, EntidadeAtiva = EntidadeAtiva.Ativo},
                //new Usuario { Id = 4, IdEntidade = 8, TipoUsuario = TipoUsuario.Morador, EntidadeAtiva = EntidadeAtiva.Ativo}

            };

            return usuarios;
        }

        #endregion

        #region Informativo

        public ICollection<Informativo> SelecionaInformativos()
        {
            var informativos = new List<Informativo>
            {
                new Informativo{ Id = 1,IdEntidade = 0, TipoInformante = TipoInformante.Anonimo, Descricao = "Crianças usando maconha no bloco C"},
                new Informativo{ Id = 2,IdEntidade = 2, TipoInformante = TipoInformante.Morador, Descricao = "Parque central com a balança quebrada, cuidado!"},
                new Informativo{ Id = 3,IdEntidade = 1, TipoInformante = TipoInformante.Funcionario, Descricao = "Manutenção eletrica nas casas da rua 1 e 2"}
            };

            return informativos;
        }

        #endregion
    }
}
