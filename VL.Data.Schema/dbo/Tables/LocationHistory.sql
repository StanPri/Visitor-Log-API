CREATE TABLE [dbo].[LocationHistory] (
    [ID]         INT IDENTITY (1, 1) NOT NULL,
    [LocationID] INT NOT NULL,
    CONSTRAINT [PK_LocationHistory] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_LocationHistory_Location] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID])
);

