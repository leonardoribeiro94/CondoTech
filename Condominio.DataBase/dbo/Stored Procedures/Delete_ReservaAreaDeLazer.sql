﻿CREATE PROCEDURE Delete_ReservaAreaDeLazer

@IdReservaAreaDeLazer int,

@Status bit

AS
BEGIN

UPDATE [dbo].[reservaareadelazer] 
SET 
 status = @Status 

WHERE 
 idreservaareadelazer = @IdReservaAreaDeLazer

END