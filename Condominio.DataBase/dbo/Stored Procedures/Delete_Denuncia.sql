create procedure [dbo].[Delete_Denuncia]
@IdDenuncia int,
@Ativo bit

as 

begin

update [dbo].[Denuncia] set  [dbo].[Denuncia].[Ativo] = @Ativo
                     where [dbo].[Denuncia].[IdDenuncia] = @IdDenuncia;


end

