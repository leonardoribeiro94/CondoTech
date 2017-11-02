CREATE procedure [dbo].[Insert_Morador]

@Nome varchar(50),
@DataDeNascimento datetime,
@Telefone char(10) = null,
@Celular char(11) = null,
@Email varchar(150),
@Cpf char(11),
@Ativo bit

AS

BEGIN

INSERT INTO [dbo].[Morador]([dbo].[Morador].[Nome],
                    [dbo].[Morador].[DataDeNascimento],
					[dbo].[Morador].[Telefone],
					[dbo].[Morador].[Celular],
					[dbo].[Morador].[Email],
					[dbo].[Morador].[Cpf],
					[dbo].[Morador].[Ativo])

			 VALUES(@Nome,
			       @DataDeNascimento,
				   @Telefone,
				   @Celular,
				   @Email,
				   @Cpf,
				   @Ativo);


declare @SetIdentity int;
set @SetIdentity = (select @@IDENTITY);

 INSERT INTO [dbo].[UsuarioMorador]([dbo].[UsuarioMorador].[IdMorador],
                            [dbo].[UsuarioMorador].[Login],
							[dbo].[UsuarioMorador].[senha],
							[dbo].[UsuarioMorador].[SenhaTemporaria],
							[dbo].[UsuarioMorador].[Ativo])
		              VALUES(@SetIdentity,
					         @Cpf,
							 'morador@123',
							  1,
							 @Ativo)
END
