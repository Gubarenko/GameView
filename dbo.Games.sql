CREATE TABLE [dbo].[Games] (
    [GameId]          INT            IDENTITY (1, 1) NOT NULL,
    [GameName]        NVARCHAR (MAX) NOT NULL,
    [LogGame]         NVARCHAR (MAX) NOT NULL,
    [YearGame]        INT            NOT NULL,
    [GameDev] NVARCHAR (MAX) NOT NULL,
    [DescriptionGame] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_dbo.Games] PRIMARY KEY CLUSTERED ([GameId] ASC)
);

