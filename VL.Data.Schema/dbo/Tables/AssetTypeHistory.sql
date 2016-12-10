CREATE TABLE [dbo].[AssetTypeHistory] (
    [ID]          INT IDENTITY (1, 1) NOT NULL,
    [AssetTypeID] INT NOT NULL,
    CONSTRAINT [PK_AssetTypeHistory] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_AssetTypeHistory_AssetType] FOREIGN KEY ([AssetTypeID]) REFERENCES [dbo].[AssetType] ([ID])
);

