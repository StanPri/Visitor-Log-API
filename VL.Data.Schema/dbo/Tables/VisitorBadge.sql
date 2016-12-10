CREATE TABLE [dbo].[VisitorBadge] (
    [VisitorID]   INT NOT NULL,
    [BadgeID]     INT NOT NULL,
    [BadgeTypeID] INT NOT NULL,
    CONSTRAINT [PK_VisitorBadge] PRIMARY KEY CLUSTERED ([VisitorID] ASC, [BadgeID] ASC, [BadgeTypeID] ASC),
    CONSTRAINT [FK_VisitorBadge_Badge] FOREIGN KEY ([BadgeID]) REFERENCES [dbo].[Badge] ([ID]),
    CONSTRAINT [FK_VisitorBadge_BadgeType1] FOREIGN KEY ([BadgeTypeID]) REFERENCES [dbo].[BadgeType] ([ID]),
    CONSTRAINT [FK_VisitorBadge_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);

