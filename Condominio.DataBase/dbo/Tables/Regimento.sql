CREATE TABLE [dbo].[Regimento] (
    [IdRegimento]   INT             IDENTITY (1, 1) NOT NULL,
    [IdFuncionario] INT             NOT NULL,
    [Nome]          VARCHAR (50)    NOT NULL,
    [Descricao]     VARCHAR (MAX)   NOT NULL,
    [Documento]     VARBINARY (MAX) NULL,
    [Ativo]         BIT             NOT NULL,
    CONSTRAINT [PK_Regimento] PRIMARY KEY CLUSTERED ([IdRegimento] ASC),
    CONSTRAINT [FK_Regimento_Funcionario] FOREIGN KEY ([IdRegimento]) REFERENCES [dbo].[Funcionario] ([IdFuncionario])
);

