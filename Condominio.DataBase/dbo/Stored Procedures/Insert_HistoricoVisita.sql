create procedure [dbo].[Insert_HistoricoVisita]
@IdMorador int,
@IdVisitante int,
@DataEntrada datetime,
@DataSaida datetime,
@Descricao varchar(max)

as

insert into [dbo].[HistoricoVisita]([dbo].[HistoricoVisita].[IdMorador],
                            [dbo].[HistoricoVisita].[IdVisitante],
							[dbo].[HistoricoVisita].[DataEntrada],
							[dbo].[HistoricoVisita].[DataSaida],
							[dbo].[HistoricoVisita].[Descricao])
					values (@IdMorador,
					        @IdVisitante,
							@DataEntrada,
							@DataSaida,
							@Descricao);
