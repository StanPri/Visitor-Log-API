CREATE TABLE [dbo].[AssetHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [AssetID]          INT          NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_AssetHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);



