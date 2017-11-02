CREATE TABLE [dbo].[Funcionario] (
    [IdFuncionario]    INT           IDENTITY (1, 1) NOT NULL,
    [IdCargo]          INT           NOT NULL,
    [Nome]             VARCHAR (50)  NOT NULL,
    [DataDeNascimento] DATETIME      NOT NULL,
    [Telefone]         CHAR (10)     NULL,
    [Celular]          CHAR (11)     NULL,
    [Email]            VARCHAR (100) NULL,
    [Cpf]              CHAR (11)     NOT NULL,
    [Ativo]            BIT           NOT NULL,
    CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED ([IdFuncionario] ASC),
    CONSTRAINT [FK_Funcionario_Cargo] FOREIGN KEY ([IdCargo]) REFERENCES [dbo].[Cargo] ([IdCargo]),
    CONSTRAINT [Unique_Cpf_Funcionario] UNIQUE NONCLUSTERED ([Cpf] ASC)
);

