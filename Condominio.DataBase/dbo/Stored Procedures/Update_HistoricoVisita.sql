Create procedure [dbo].[Update_HistoricoVisita]
@IdMorador int,
@IdHistoricoVisita int,
@IdVisitante int,
@DataEntrada datetime,
@DataSaida datetime,
@Descricao varchar(max)

as

update [dbo].[HistoricoVisita]  set [dbo].[HistoricoVisita].[IdMorador] =@IdMorador,
                            [dbo].[HistoricoVisita].[IdVisitante] = @IdVisitante,
							[dbo].[HistoricoVisita].[DataEntrada] = @DataEntrada,
							[dbo].[HistoricoVisita].[DataSaida] = @DataSaida,
							[dbo].[HistoricoVisita].[Descricao] = @Descricao
					 
					 where [dbo].[HistoricoVisita].[IdHistoricoVisita] = @IdHistoricoVisita
