CREATE TABLE [dbo].[VisitorBadge] (
    [VisitorID]        INT          NOT NULL,
    [BadgeID]          INT          NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_VisitorBadge_1] PRIMARY KEY CLUSTERED ([VisitorID] ASC, [BadgeID] ASC),
    CONSTRAINT [FK_VisitorBadge_Badge] FOREIGN KEY ([BadgeID]) REFERENCES [dbo].[Badge] ([ID]),
    CONSTRAINT [FK_VisitorBadge_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);



