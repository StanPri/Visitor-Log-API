CREATE TABLE [dbo].[BadgeTypeBadge] (
    [BadgeTypeID]      INT          NOT NULL,
    [BadgeID]          INT          NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_BadgeTypeBadge] PRIMARY KEY CLUSTERED ([BadgeTypeID] ASC, [BadgeID] ASC),
    CONSTRAINT [FK_BadgeTypeBadge_Badge] FOREIGN KEY ([BadgeID]) REFERENCES [dbo].[Badge] ([ID]),
    CONSTRAINT [FK_BadgeTypeBadge_BadgeType] FOREIGN KEY ([BadgeTypeID]) REFERENCES [dbo].[BadgeType] ([ID])
);

