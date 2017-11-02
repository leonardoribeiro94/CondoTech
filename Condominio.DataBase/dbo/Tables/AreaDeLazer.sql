CREATE TABLE [dbo].[AreaDeLazer] (
    [IdAreaDeLazer] INT             IDENTITY (1, 1) NOT NULL,
    [Imagem]        VARBINARY (MAX) NULL,
    [Nome]          VARCHAR (50)    NOT NULL,
    [Descricao]     VARCHAR (MAX)   NULL,
    [Ativo]         BIT             NOT NULL,
    CONSTRAINT [PK_AreaDeLazer] PRIMARY KEY CLUSTERED ([IdAreaDeLazer] ASC)
);

