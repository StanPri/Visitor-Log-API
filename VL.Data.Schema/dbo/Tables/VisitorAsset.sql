﻿CREATE TABLE [dbo].[VisitorAsset] (
    [VisitorID]        INT          NOT NULL,
    [VisitID]          INT          NOT NULL,
    [AssetID]          INT          NOT NULL,
    [AssetTypeID]      INT          NOT NULL,
    [Comment]          VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_VisitorAsset] PRIMARY KEY CLUSTERED ([VisitorID] ASC, [VisitID] ASC, [AssetID] ASC, [AssetTypeID] ASC),
    CONSTRAINT [FK_VisitorAsset_Asset] FOREIGN KEY ([AssetID]) REFERENCES [dbo].[Asset] ([ID]),
    CONSTRAINT [FK_VisitorAsset_AssetType] FOREIGN KEY ([AssetTypeID]) REFERENCES [dbo].[AssetType] ([ID]),
    CONSTRAINT [FK_VisitorAsset_Visit] FOREIGN KEY ([VisitID]) REFERENCES [dbo].[Visit] ([ID]),
    CONSTRAINT [FK_VisitorAsset_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);

