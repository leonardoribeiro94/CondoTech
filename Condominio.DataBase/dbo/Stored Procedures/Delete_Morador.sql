CREATE PROCEDURE [dbo].[Delete_Morador]
@IdMorador int,
@Ativo bit

AS

BEGIN

UPDATE [dbo].[Morador] SET [dbo].[Morador].[Ativo] = @Ativo                
			   WHERE [dbo].[Morador].[IdMorador] = @IdMorador			     

			   update [dbo].[UsuarioMorador] set [dbo].[UsuarioMorador].[Ativo] = @Ativo
						                          where [dbo].[UsuarioMorador].[IdMorador] = @IdMorador 
END
