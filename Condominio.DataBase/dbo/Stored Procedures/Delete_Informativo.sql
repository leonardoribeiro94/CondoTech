create procedure [dbo].[Delete_Informativo] 

@IdInformativo int, 
@Ativo bit

as
begin

  Update [dbo].[Informativo] set  [dbo].[Informativo].[Ativo] = @Ativo

						  where [dbo].[Informativo].[IdInformativo] = @IdInformativo

end
