CREATE TABLE [dbo].[Station] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Code]             VARCHAR (50) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     CONSTRAINT [DF_Station_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     CONSTRAINT [DF_Station_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    [IsActive]         BIT          CONSTRAINT [DF_Station_IsActive] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trgStationHistoryRecord] ON [dbo].[Station] 
AFTER UPDATE AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF(UPDATE(CODE) OR UPDATE(NAME) OR UPDATE(IsActive))
    INSERT INTO StationHistory (StationID, Code, Name, IsActive, ModifiedByUserID, ModifiedDate, AuditDate)
	SELECT ID, Code, Name, IsActive, ModifiedByUserID, ModifiedDate, GETDATE()
	FROM deleted

END