CREATE PROCEDURE [dbo].[Delete_AreaDeLazer]
(
@IdAreaDeLazer int,
@Ativo char(8)
)

AS
BEGIN

UPDATE [dbo].[AreaDeLazer] SET  [dbo].[AreaDeLazer].[Ativo] = @Ativo

			       WHERE [dbo].[AreaDeLazer].[IdAreaDeLazer] = @IdAreaDeLazer


END
