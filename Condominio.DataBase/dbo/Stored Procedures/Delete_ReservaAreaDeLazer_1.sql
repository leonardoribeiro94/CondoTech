CREATE PROCEDURE Delete_ReservaAreaDeLazer

@IdReservaAreaDeLazer int,

@Status bit

AS
BEGIN

UPDATE [dbo].[reservaareadelazer] 
SET 
 StatusReserva = @Status 

WHERE 
 IdReservaAreaDeLazer = @IdReservaAreaDeLazer

END