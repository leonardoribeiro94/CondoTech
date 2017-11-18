CREATE PROCEDURE [dbo].[Update_AreaDeLazer]
(
@IdAreaDeLazer int,
@Imagem varbinary(max) = null,
@Nome varchar(50),
@Descricao varchar(max),
@Ativo bit
)

AS

BEGIN
UPDATE [dbo].[AreaDeLazer] SET  [dbo].[AreaDeLazer].[Imagem] = @Imagem,
                        [dbo].[AreaDeLazer].[Nome] = @Nome,
						[dbo].[AreaDeLazer].[Descricao] = @Descricao,
						[dbo].[AreaDeLazer].[Ativo] = @Ativo

			       WHERE [dbo].[AreaDeLazer].[IdAreaDeLazer] = @IdAreaDeLazer
END
