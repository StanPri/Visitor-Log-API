CREATE TABLE [dbo].[BadgeTypeBadgeHistory] (
    [ID]              INT          IDENTITY (1, 1) NOT NULL,
    [BadgeTypeID]     INT          NOT NULL,
    [BadgeID]         INT          NOT NULL,
    [ModifedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]    DATETIME     NOT NULL,
    [AuditDate]       DATETIME     NOT NULL,
    CONSTRAINT [PK_BadgeTypeBadgeHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);

