CREATE TABLE [dbo].[ReservaAreaDeLazer] (
    [IdReservaAreaDeLazer] INT           IDENTITY (1, 1) NOT NULL,
    [IdMorador]            INT           NOT NULL,
    [IdAreaDeLazer]        INT           NOT NULL,
    [Descricao]            VARCHAR (MAX) NULL,
    [DataSolicitacao]      DATETIME      NOT NULL,
    [DataReserva]          DATETIME      NOT NULL,
    [StatusReserva]               BIT           NOT NULL,
    CONSTRAINT [PK_ReservaAreaDeLazer] PRIMARY KEY CLUSTERED ([IdReservaAreaDeLazer] ASC),
    CONSTRAINT [FK_ReservaAreaDeLazer_AreaDeLazer] FOREIGN KEY ([IdMorador]) REFERENCES [dbo].[AreaDeLazer] ([IdAreaDeLazer]),
    CONSTRAINT [FK_ReservaAreaDeLazer_Morador] FOREIGN KEY ([IdMorador]) REFERENCES [dbo].[Morador] ([IdMorador])
);



