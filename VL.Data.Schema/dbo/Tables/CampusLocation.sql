CREATE TABLE [dbo].[CampusLocation] (
    [CampusID]         INT          NOT NULL,
    [LocationID]       INT          NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_CampusLocation] PRIMARY KEY CLUSTERED ([CampusID] ASC, [LocationID] ASC),
    CONSTRAINT [FK_SiteRoom_Room] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID]),
    CONSTRAINT [FK_SiteRoom_Site] FOREIGN KEY ([CampusID]) REFERENCES [dbo].[Campus] ([ID])
);

