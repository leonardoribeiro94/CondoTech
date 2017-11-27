CREATE TABLE [dbo].[Denuncia] (
    [IdDenuncia]   INT             IDENTITY (1, 1) NOT NULL,
    [Nome]         VARCHAR (50)    NULL,
    [Celular]      CHAR (11)       NULL,
    [Email]        VARCHAR (150)   NULL,
    [Imagem]       VARBINARY (MAX) NULL,
    [Descricao]    VARCHAR (MAX)   NOT NULL,
    [DataDenuncia] DATETIME        NOT NULL,
    [Ativo]        BIT             NOT NULL,
    CONSTRAINT [PK_Denuncia] PRIMARY KEY CLUSTERED ([IdDenuncia] ASC)
);

