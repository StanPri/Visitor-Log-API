CREATE TABLE [dbo].[CampusLocation] (
    [CampusID]         INT          NOT NULL,
    [LocationID]       INT          NOT NULL,
    [CreatedByUserID]  VARCHAR (50) CONSTRAINT [DF_CampusLocation_CreatedByUserID] DEFAULT ((-1)) NOT NULL,
    [CreatedDate]      DATETIME     CONSTRAINT [DF_CampusLocation_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) CONSTRAINT [DF_CampusLocation_ModifiedByUserID] DEFAULT ((-1)) NOT NULL,
    [ModifiedDate]     DATETIME     CONSTRAINT [DF_CampusLocation_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_CampusLocation] PRIMARY KEY CLUSTERED ([CampusID] ASC, [LocationID] ASC),
    CONSTRAINT [FK_SiteRoom_Room] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID]),
    CONSTRAINT [FK_SiteRoom_Site] FOREIGN KEY ([CampusID]) REFERENCES [dbo].[Campus] ([ID])
);



