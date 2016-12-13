CREATE TABLE [dbo].[AssetTypeHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [AssetTypeID]      INT          NOT NULL,
    [Code]             VARCHAR (50) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_AssetTypeHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);



