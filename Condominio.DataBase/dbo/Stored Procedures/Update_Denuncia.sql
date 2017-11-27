CREATE procedure [dbo].[Update_Denuncia]
@IdDenuncia int,
@Nome varchar(50) = null,
@Celular varchar(11) = null,
@Email varchar(150) = null,
@Imagem varbinary = null,
@Descricao varchar(max),
@DataDenuncia datetime,
@Ativo bit

as 

begin

update [dbo].[Denuncia] set  [dbo].[Denuncia].[Nome] = @Nome,
                     [dbo].[Denuncia].[Celular] = @Celular,
					 [dbo].[Denuncia].[Email] = @Email,
					 [dbo].[Denuncia].[Imagem] = @Imagem,
					 [dbo].[Denuncia].[Descricao] = @Descricao,
					 [dbo].[Denuncia].[DataDenuncia] = @DataDenuncia,
					 [dbo].[Denuncia].[Ativo] = @Ativo

					 where [dbo].[Denuncia].[IdDenuncia] = @IdDenuncia;
end

