CREATE TABLE [dbo].[UsuarioMorador] (
    [IdUsuario]       INT          IDENTITY (1, 1) NOT NULL,
    [IdMorador]       INT          NOT NULL,
    [Login]           VARCHAR (20) NOT NULL,
    [senha]           VARCHAR (20) NOT NULL,
    [SenhaTemporaria] BIT          NOT NULL,
    [Ativo]           BIT          NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([IdUsuario] ASC),
    CONSTRAINT [FK_UsuarioMorador_Morador1] FOREIGN KEY ([IdMorador]) REFERENCES [dbo].[Morador] ([IdMorador])
);

