create procedure [dbo].[Insert_Funcionario]

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

insert into [dbo].[Funcionario]([dbo].[Funcionario].[IdCargo],
				        [dbo].[Funcionario].[Nome], 
						[dbo].[Funcionario].[DataDeNascimento], 
						[dbo].[Funcionario].[Telefone],
						[dbo].[Funcionario].[Celular],
						[dbo].[Funcionario].[Email],
						[dbo].[Funcionario].[Cpf],
						[dbo].[Funcionario].[Ativo])
						values(@IdCargo,
						       @Nome,
							   @DataDeNascimento,
							   @Telefone,
							   @Celular,
							   @Email,
							   @Cpf,
							   @Ativo);

declare @SetIdentity int;
set @SetIdentity = (select @@IDENTITY);

 INSERT INTO [dbo].[UsuarioFuncionario]([dbo].[UsuarioFuncionario].[IdFuncionario],
                            [dbo].[UsuarioFuncionario].[Login],
							[dbo].[UsuarioFuncionario].[senha],
							[dbo].[UsuarioFuncionario].[SenhaTemporaria],
							[dbo].[UsuarioFuncionario].[Ativo])
		              VALUES(@SetIdentity,
					         @Cpf,
							 'funcionario@123',
							  1,
							 @Ativo)

END