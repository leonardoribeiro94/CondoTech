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
IdMorador = @IdMorador, 
IdAreaDeLazer = @IdAreaDeLazer, 
Descricao = @Descricao, 
DataSolicitacao = @DataSolicitacao, 
DataReserva = @DataReserva, 
StatusReserva = @Status 

WHERE 
IdReservaAreaDeLazer = @IdReservaAreaDeLazer

END