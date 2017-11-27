CREATE TABLE [dbo].[Visitante] (
    [IdVisitante] INT             IDENTITY (1, 1) NOT NULL,
    [Imagem]      VARBINARY (MAX) NULL,
    [Nome]        VARCHAR (50)    NOT NULL,
    [Cpf]         CHAR (11)       NOT NULL,
    [Email]       VARCHAR (150)   NOT NULL,
    [Celular]     VARCHAR (11)    NOT NULL,
    [Telefone]    VARCHAR (10)    NULL,
    [Ativo]       BIT             NOT NULL,
    CONSTRAINT [PK_Visitante] PRIMARY KEY CLUSTERED ([IdVisitante] ASC)
);

