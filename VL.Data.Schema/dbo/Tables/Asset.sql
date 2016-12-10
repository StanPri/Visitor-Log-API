CREATE TABLE [dbo].[Asset] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreateDate]       DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_Asset] PRIMARY KEY CLUSTERED ([ID] ASC)
);

