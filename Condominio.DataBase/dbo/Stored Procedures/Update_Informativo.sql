CREATE procedure [dbo].[Update_Informativo] 
@IdInformativo int, 
@IdFuncionario int,
@Titulo varchar(50),
@Descricao varchar(max),
@DataCadastro datetime, 
@Ativo bit

as
begin

  Update [dbo].[Informativo] set  [dbo].[Informativo].[IdFuncionario] = @IdFuncionario,
                          [dbo].[Informativo].[Titulo] = @Titulo,
						  [dbo].[Informativo].[Descricao] = @Descricao,
						  [dbo].[Informativo].[DataCadastro] = @DataCadastro,
						  [dbo].[Informativo].[Ativo] = @Ativo

						  where [dbo].[Informativo].[IdInformativo] = @IdInformativo				   
end