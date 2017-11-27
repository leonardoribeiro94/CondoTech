CREATE procedure [dbo].[Insert_Visitante]
@Imagem varbinary(max),
@Nome varchar(50),
@Cpf char(11),
@Email varchar(150),
@Celular varchar(11),
@Telefone varchar(10),
@Ativo bit
as

insert into [dbo].[Visitante]([dbo].[Visitante].[Imagem], 
                      [dbo].[Visitante].[Nome],
					  [dbo].[Visitante].[Cpf],
					  [dbo].[Visitante].[Email],
					  [dbo].[Visitante].[Celular],
					  [dbo].[Visitante].[Telefone],
					  [dbo].[Visitante].[Ativo])
		  
			   values(@Imagem,
			          @Nome,
					  @Cpf,
				      @Email,
					  @Celular,
					  @Telefone,
					  @Ativo)
