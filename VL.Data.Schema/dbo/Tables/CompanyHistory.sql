CREATE TABLE [dbo].[CompanyHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [CompanyID]        INT          NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_CompanyHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);

