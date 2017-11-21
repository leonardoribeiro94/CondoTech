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

UPDATE [ReservaAreaDeLazer] 
SET 
idmorador = @IdMorador, 
idareadelazer = @IdAreaDeLazer, 
descricao = @Descricao, 
datasolicitacao = @DataSolicitacao, 
datareserva = @DataReserva, 
StatusReserva = @Status 

WHERE 
IdReservaAreaDeLazer = @IdReservaAreaDeLazer

END