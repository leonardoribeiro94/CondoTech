CREATE TABLE [dbo].[Fornecedor] (
    [IdFornecedor] INT           IDENTITY (1, 1) NOT NULL,
    [Nome]         VARCHAR (80)  NOT NULL,
    [Cnpj]         CHAR (14)     NOT NULL,
    [Telefone]     CHAR (10)     NOT NULL,
    [Celular]      CHAR (11)     NULL,
    [Email]        VARCHAR (100) NOT NULL,
    [Descricao]    VARCHAR (MAX) NOT NULL,
    [Ativo]        BIT           NOT NULL,
    CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED ([IdFornecedor] ASC)
);

