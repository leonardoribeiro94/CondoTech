CREATE procedure [dbo].[Insert_Informativo] 

@IdFuncionario int,
@Titulo varchar(50),
@Descricao varchar(max),
@DataCadastro datetime, 
@Documento varbinary(max) = null,
@Ativo bit

as
begin

insert into [dbo].[Informativo]([dbo].[Informativo].[IdFuncionario],
                        [dbo].[Informativo].[Titulo],
						[dbo].[Informativo].[Descricao],
						[dbo].[Informativo].[DataCadastro],
						[dbo].[Informativo].[Documento],
						[dbo].[Informativo].[Ativo])

						values(@IdFuncionario,
						       @Titulo,
						       @Descricao,
							   @DataCadastro,
							   @Documento,
							   @Ativo)

end