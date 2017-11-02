CREATE TABLE [dbo].[UsuarioFuncionario] (
    [IdUsuario]       INT           IDENTITY (1, 1) NOT NULL,
    [IdFuncionario]   INT           NOT NULL,
    [Login]           VARCHAR (20)  NOT NULL,
    [Senha]           VARCHAR (MAX) NOT NULL,
    [SenhaTemporaria] BIT           NOT NULL,
    [Ativo]           BIT           NOT NULL,
    CONSTRAINT [PK_UsuarioFuncionario] PRIMARY KEY CLUSTERED ([IdUsuario] ASC),
    CONSTRAINT [FK_UsuarioFuncionario_Funcionario] FOREIGN KEY ([IdFuncionario]) REFERENCES [dbo].[Funcionario] ([IdFuncionario])
);

