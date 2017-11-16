CREATE PROCEDURE Insert_ReservaAreaDeLazer

@IdMorador int,
@IdAreaDeLazer int,
@Descricao varchar(max),
@DataSolicitacao datetime,
@DataReserva datetime,
@Status bit

AS
BEGIN
INSERT INTO [dbo].[reservaareadelazer]
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