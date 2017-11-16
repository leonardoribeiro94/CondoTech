CREATE PROCEDURE Update_ReservaAreaDeLazer

@IdReservaAreaDeLazer int,
@IdMorador int,
@IdAreaDeLazer int,
@Descricao varchar(max),
@DataSolicitacao datetime,
@DataReserva datetime,
@Status bit

AS
BEGIN

UPDATE [dbo].[reservaareadelazer] 
SET 
idmorador = @IdMorador, 
idareadelazer = @IdAreaDeLazer, 
descricao = @Descricao, 
datasolicitacao = @DataSolicitacao, 
datareserva = @DataReserva, 
StatusReserva = @Status 

WHERE 
idreservaareadelazer = @IdReservaAreaDeLazer

END