CREATE PROCEDURE Delete_ReservaAreaDeLazer

@IdReservaAreaDeLazer int,

@Status bit

AS
BEGIN

UPDATE [ReservaAreaDeLazer] 
SET 
 StatusReserva = @Status 

WHERE 
 IdReservaAreaDeLazer = @IdReservaAreaDeLazer

END