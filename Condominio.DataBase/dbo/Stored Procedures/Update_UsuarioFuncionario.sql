CREATE procedure [dbo].[Update_UsuarioFuncionario]

@IdUsuario int,
@Senha varchar(max),
@SenhaTemporaria bit,
@Ativo bit

as
begin

update [dbo].[UsuarioFuncionario] set [dbo].[UsuarioFuncionario].[Senha] = @Senha,
							  [dbo].[UsuarioFuncionario].[SenhaTemporaria] = @SenhaTemporaria,
							  [dbo].[UsuarioFuncionario].[Ativo] = @Ativo
							  where [dbo].[UsuarioFuncionario].[IdUsuario] = @IdUsuario

end
                          
