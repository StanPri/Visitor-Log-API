CREATE TABLE [dbo].[BadgeHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [BadgeID]          INT          NOT NULL,
    [Number]           VARCHAR (50) NOT NULL,
    [IsActive]         BIT          NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_BadgeHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);



