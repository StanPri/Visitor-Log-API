CREATE TABLE [dbo].[AssetTypeAssetHistory] (
    [ID]               INT        IDENTITY (1, 1) NOT NULL,
    [AssetTypeID]      NCHAR (10) NULL,
    [AssetID]          NCHAR (10) NOT NULL,
    [ModifiedByUserID] NCHAR (10) NOT NULL,
    [ModifiedDate]     NCHAR (10) NOT NULL,
    [AuditDate]        DATETIME   NOT NULL,
    CONSTRAINT [PK_AssetTypeAssetHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);

