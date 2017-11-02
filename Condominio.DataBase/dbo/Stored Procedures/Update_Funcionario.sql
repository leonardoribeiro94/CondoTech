create procedure [dbo].[Update_Funcionario]
@IdFuncionario int,
@IdCargo int,
@Nome varchar(50),
@DataDeNascimento datetime,
@Telefone char(10) = null,
@Celular char(11) = null,
@Email varchar(150),
@Cpf char(11),
@Ativo char(8)

AS
BEGIN

update [dbo].[Funcionario] set  [dbo].[Funcionario].[IdCargo] = @IdCargo,
				        [dbo].[Funcionario].[Nome] = @Nome, 
						[dbo].[Funcionario].[DataDeNascimento] = @DataDeNascimento, 
						[dbo].[Funcionario].[Telefone] = @Telefone,
						[dbo].[Funcionario].[Celular] = @Celular,
						[dbo].[Funcionario].[Email] = @Email,
						[dbo].[Funcionario].[Cpf] = @Cpf,
						[dbo].[Funcionario].[Ativo] = @Ativo
						where [dbo].[Funcionario].[IdFuncionario] = @IdFuncionario
END
