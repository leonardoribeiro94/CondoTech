CREATE PROCEDURE [dbo].[Insert_AreaDeLazer]
(
@Nome varchar(50),
@Descricao varchar(max),
@Imagem varbinary(max),
@Ativo bit
)

AS
BEGIN

INSERT INTO [dbo].[AreaDeLazer]([dbo].[AreaDeLazer].[Imagem],
                        [dbo].[AreaDeLazer].[Nome],
						[dbo].[AreaDeLazer].[Descricao],
						[dbo].[AreaDeLazer].[Ativo])

			    VALUES  (@Imagem,
				         @Nome,
						 @Descricao,
						 @Ativo)


END
