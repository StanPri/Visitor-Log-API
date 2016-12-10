CREATE TABLE [dbo].[CampusStation] (
    [CampusID]         INT          NOT NULL,
    [StationID]        INT          NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_CampusStation] PRIMARY KEY CLUSTERED ([CampusID] ASC, [StationID] ASC),
    CONSTRAINT [FK_CampusStation_Campus] FOREIGN KEY ([CampusID]) REFERENCES [dbo].[Campus] ([ID]),
    CONSTRAINT [FK_CampusStation_Station] FOREIGN KEY ([StationID]) REFERENCES [dbo].[Station] ([ID])
);

