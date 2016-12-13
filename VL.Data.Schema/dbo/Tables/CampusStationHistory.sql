CREATE TABLE [dbo].[CampusStationHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [CampusID]         INT          NOT NULL,
    [StationID]        INT          NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_CampusStationHistory_1] PRIMARY KEY CLUSTERED ([ID] ASC)
);



