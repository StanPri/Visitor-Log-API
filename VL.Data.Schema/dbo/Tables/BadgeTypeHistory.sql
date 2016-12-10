CREATE TABLE [dbo].[BadgeTypeHistory] (
    [ID]          INT IDENTITY (1, 1) NOT NULL,
    [BadgeTypeID] INT NOT NULL,
    CONSTRAINT [PK_BadgeTypeHistory] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_BadgeTypeHistory_BadgeType] FOREIGN KEY ([BadgeTypeID]) REFERENCES [dbo].[BadgeType] ([ID])
);

