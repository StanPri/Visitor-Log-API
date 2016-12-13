CREATE TABLE [dbo].[AssetTypeAsset] (
    [AssetTypeID]      INT          IDENTITY (1, 1) NOT NULL,
    [AssetID]          INT          NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_AssetTypeAsset] PRIMARY KEY CLUSTERED ([AssetTypeID] ASC, [AssetID] ASC),
    CONSTRAINT [FK_AssetTypeAsset_Asset] FOREIGN KEY ([AssetID]) REFERENCES [dbo].[Asset] ([ID]),
    CONSTRAINT [FK_AssetTypeAsset_AssetType] FOREIGN KEY ([AssetTypeID]) REFERENCES [dbo].[AssetType] ([ID])
);

