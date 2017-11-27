CREATE TABLE [dbo].[Cargo] (
    [IdCargo]   INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (50)  NOT NULL,
    [Descrição] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED ([IdCargo] ASC)
);

