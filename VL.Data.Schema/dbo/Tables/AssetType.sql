﻿CREATE TABLE [dbo].[AssetType] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Code]             VARCHAR (50) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_AssetType] PRIMARY KEY CLUSTERED ([ID] ASC)
);



