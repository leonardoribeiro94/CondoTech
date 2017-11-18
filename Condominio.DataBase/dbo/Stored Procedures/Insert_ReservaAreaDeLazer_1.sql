CREATE PROCEDURE Insert_ReservaAreaDeLazer

@IdMorador int,
@IdAreaDeLazer int,
@Descricao varchar(max),
@DataSolicitacao datetime,
@DataReserva date,
@Status bit

AS
BEGIN
INSERT INTO [dbo].[ReservaAreaDeLazer]
(idmorador,
idareadelazer,
descricao,
datasolicitacao,
datareserva,
StatusReserva)

VALUES(@IdMorador,
@IdAreaDeLazer,
@Descricao,
@DataSolicitacao,
@DataReserva,
@Status)

END