create procedure [dbo].[Delete_Visitante]
@IdVisitante int,
@Ativo bit

as

update [dbo].[Visitante] set [dbo].[Visitante].[Ativo] = @Ativo 
                 where [dbo].[Visitante].[IdVisitante] = @IdVisitante
