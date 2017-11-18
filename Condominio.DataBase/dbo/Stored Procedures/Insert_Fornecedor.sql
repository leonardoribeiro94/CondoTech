CREATE PROCEDURE [dbo].[Insert_Fornecedor]

@Nome varchar(80),
@Cnpj char(14),
@Telefone char(10),
@Celular char(11),
@Email varchar(100),
@Descricao varchar(max),
@Ativo char(8)

AS

BEGIN

INSERT INTO [dbo].[Fornecedor]([Nome],
					   [Cnpj],
					   [Telefone],
					   [Celular],
					   [Email],
					   [Descricao],
					   [Ativo])
			    VALUES (@nome,
						@Cnpj,
						@Telefone,
						@Celular,
						@Email,
						@Descricao,
						@Ativo)  
END
