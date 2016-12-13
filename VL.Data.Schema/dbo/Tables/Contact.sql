CREATE TABLE [dbo].[Contact] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [ContactUserID]    VARCHAR (50) NOT NULL,
    [Phone]            VARCHAR (50) NOT NULL,
    [Mobile]           VARCHAR (50) NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([ID] ASC)
);

