CREATE procedure [dbo].[Insert_Denuncia]
@Nome varchar(50) = null,
@Celular varchar(11) = null,
@Email varchar(150) = null,
@Imagem varbinary(max) = null,
@Descricao varchar(max),
@DataDenuncia datetime,
@Ativo bit

as 

begin

insert into Denuncia(Nome,
                     Celular,
					 Email,
					 Imagem,
					 Descricao,
					 DataDenuncia,
					 Ativo)

					 values(@Nome,
					        @Celular,
							@Email,
							@Imagem,
							@Descricao,
							@DataDenuncia,
							@Ativo);

end