CREATE TABLE [dbo].[HistoricoVisita] (
    [IdHistoricoVisita] INT           IDENTITY (1, 1) NOT NULL,
    [IdMorador]         INT           NOT NULL,
    [IdVisitante]       INT           NOT NULL,
    [DataEntrada]       DATETIME      NOT NULL,
    [DataSaida]         DATETIME      NULL,
    [Descricao]         VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_HistoricoVisita] PRIMARY KEY CLUSTERED ([IdHistoricoVisita] ASC),
    CONSTRAINT [FK_HistoricoVisita_Morador] FOREIGN KEY ([IdMorador]) REFERENCES [dbo].[Morador] ([IdMorador]),
    CONSTRAINT [FK_HistoricoVisita_Visitante] FOREIGN KEY ([IdVisitante]) REFERENCES [dbo].[Visitante] ([IdVisitante])
);

