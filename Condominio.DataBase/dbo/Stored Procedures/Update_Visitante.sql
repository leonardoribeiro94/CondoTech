CREATE procedure [dbo].[Update_Visitante]
@IdVisitante int,
@Imagem varbinary(max) = null,
@Nome varchar(50),
@Cpf char(11),
@Email varchar(150),
@Celular varchar(11),
@Telefone varchar(10),
@Ativo bit
as

update [dbo].[Visitante] set  [dbo].[Visitante].[Imagem] = @Imagem, 
                      [dbo].[Visitante].[Nome] = @Nome,
					  [dbo].[Visitante].[Cpf] = @Cpf,
					  [dbo].[Visitante].[Email] = @Email,
					  [dbo].[Visitante].[Celular] = @Celular,
					  [dbo].[Visitante].[Telefone] = @Telefone,
					  [dbo].[Visitante].[Ativo] = @Ativo
					  where [dbo].[Visitante].[IdVisitante] = @IdVisitante
