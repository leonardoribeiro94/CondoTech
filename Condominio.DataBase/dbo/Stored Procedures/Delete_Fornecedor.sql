CREATE PROCEDURE [dbo].[Delete_Fornecedor]

@IdFornecedor INT,
@Ativo char(8)

AS
BEGIN
 UPDATE [dbo].[Fornecedor] SET [dbo].[Fornecedor].[Ativo] = @Ativo 
END

