CREATE TABLE [dbo].[Morador] (
    [IdMorador]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]             VARCHAR (50)  NOT NULL,
    [DataDeNascimento] DATETIME      NOT NULL,
    [Telefone]         CHAR (10)     NULL,
    [Celular]          CHAR (11)     NULL,
    [Email]            VARCHAR (150) NULL,
    [Cpf]              CHAR (11)     NOT NULL,
    [Ativo]            BIT           NOT NULL,
    CONSTRAINT [PK_Morador] PRIMARY KEY CLUSTERED ([IdMorador] ASC),
    CONSTRAINT [Unique_Cpf] UNIQUE NONCLUSTERED ([Cpf] ASC)
);

