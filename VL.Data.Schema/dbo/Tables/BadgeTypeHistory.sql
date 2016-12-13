CREATE TABLE [dbo].[BadgeTypeHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [BadgeTypeID]      INT          NOT NULL,
    [Code]             VARCHAR (50) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_BadgeTypeHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);



