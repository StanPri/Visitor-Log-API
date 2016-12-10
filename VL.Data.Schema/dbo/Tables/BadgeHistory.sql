CREATE TABLE [dbo].[BadgeHistory] (
    [ID]      INT IDENTITY (1, 1) NOT NULL,
    [BadgeID] INT NOT NULL,
    CONSTRAINT [PK_BadgeHistory] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_BadgeHistory_Badge] FOREIGN KEY ([BadgeID]) REFERENCES [dbo].[Badge] ([ID])
);

