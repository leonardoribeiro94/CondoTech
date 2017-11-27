CREATE TABLE [dbo].[Informativo] (
    [IdInformativo] INT             IDENTITY (1, 1) NOT NULL,
    [IdFuncionario] INT             NOT NULL,
    [Titulo]        VARCHAR (50)    NOT NULL,
    [Descricao]     VARCHAR (MAX)   NOT NULL,
    [DataCadastro]  DATETIME        NOT NULL,
    [Documento]     VARBINARY (MAX) NULL,
    [Ativo]         BIT             NOT NULL,
    CONSTRAINT [PK_Informativo] PRIMARY KEY CLUSTERED ([IdInformativo] ASC),
    CONSTRAINT [FK_Informativo_Funcionario] FOREIGN KEY ([IdFuncionario]) REFERENCES [dbo].[Funcionario] ([IdFuncionario])
);

