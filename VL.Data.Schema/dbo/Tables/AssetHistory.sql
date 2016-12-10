CREATE TABLE [dbo].[AssetHistory] (
    [ID]      INT IDENTITY (1, 1) NOT NULL,
    [AssetID] INT NOT NULL,
    CONSTRAINT [PK_AssetHistory] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_AssetHistory_Asset] FOREIGN KEY ([AssetID]) REFERENCES [dbo].[Asset] ([ID])
);

