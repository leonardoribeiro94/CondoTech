CREATE PROCEDURE [dbo].[Update_Morador]
@IdMorador int,
@Nome varchar(50),
@DataDeNascimento datetime = null,
@Telefone char(10) = null,
@Celular char(11) = null,
@Email varchar(150) = null,
@Cpf char(11) = null,
@Ativo char(8) = null

AS

BEGIN

UPDATE  [dbo].[Morador] SET [dbo].[Morador].[Nome] = @Nome,
                    [dbo].[Morador].[DataDeNascimento] = @DataDeNascimento,
					[dbo].[Morador].[Telefone] = @Telefone,
					[dbo].[Morador].[Celular] = @Celular,
					[dbo].[Morador].[Email] = @Email,
					[dbo].[Morador].[Cpf] = @Cpf,
					[dbo].[Morador].[Ativo] = @Ativo
            
			 WHERE [dbo].[Morador].[IdMorador] = @IdMorador			     
END
