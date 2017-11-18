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

insert into [dbo].[Funcionario]([IdCargo],
				        [Nome], 
						[DataDeNascimento], 
						[Telefone],
						[Celular],
						[Email],
						[Cpf],
						[Ativo])
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

 INSERT INTO [dbo].[UsuarioFuncionario]([IdFuncionario],
                            [Login],
							[senha],
							[SenhaTemporaria],
							[Ativo])
		              VALUES(@SetIdentity,
					         @Cpf,
							 'funcionario@123',
							  1,
							 @Ativo)

END