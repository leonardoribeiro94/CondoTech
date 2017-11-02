CREATE PROCEDURE [dbo].[Update_Fornecedor]
@IdFornecedor int,
@Nome varchar(80),
@Cnpj char(14),
@Telefone char(10),
@Celular char(11),
@Email varchar(100),
@Descricao varchar(max),
@Ativo char(8)

AS

BEGIN

UPDATE [dbo].[Fornecedor] SET  [dbo].[Fornecedor].[Nome] = @Nome,
					   [dbo].[Fornecedor].[Cnpj] = @Cnpj,
					   [dbo].[Fornecedor].[Telefone] = @Telefone,
					   [dbo].[Fornecedor].[Celular] = @Celular,
					   [dbo].[Fornecedor].[Email] = @Email,
					   [dbo].[Fornecedor].[Descricao] = @Descricao,
					   [dbo].[Fornecedor].[Ativo] = @Ativo
				 WHERE [dbo].[Fornecedor].[IdFornecedor] = @IdFornecedor
END
