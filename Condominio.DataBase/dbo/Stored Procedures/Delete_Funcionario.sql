create procedure [dbo].[Delete_Funcionario]

@IdFuncionario int,
@Ativo bit

AS
BEGIN

update [dbo].[Funcionario] set  [dbo].[Funcionario].[Ativo] = @Ativo
						where [dbo].[Funcionario].[IdFuncionario] = @IdFuncionario

						update [dbo].[UsuarioFuncionario] set [dbo].[UsuarioFuncionario].[Ativo] = @Ativo
						                          where [dbo].[UsuarioFuncionario].[IdFuncionario] = @IdFuncionario  
END
