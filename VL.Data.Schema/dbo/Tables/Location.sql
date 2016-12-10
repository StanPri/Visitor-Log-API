CREATE TABLE [dbo].[Location] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([ID] ASC)
);

