CREATE TABLE [dbo].[Campus] (
    [ID]               INT           IDENTITY (1, 1) NOT NULL,
    [Code]             VARCHAR (10)  NOT NULL,
    [Name]             VARCHAR (50)  NOT NULL,
    [Address]          VARCHAR (128) NULL,
    [Address2]         VARCHAR (128) NULL,
    [City]             VARCHAR (50)  NULL,
    [ZipCode]          VARCHAR (10)  NULL,
    [IsActive]         BIT           CONSTRAINT [DF_Campus_Active] DEFAULT ((0)) NOT NULL,
    [CreatedByUserID]  VARCHAR (50)  CONSTRAINT [DF_Campus_CreatedByUserID] DEFAULT ((-1)) NOT NULL,
    [CreatedDate]      DATETIME      CONSTRAINT [DF_Campus_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50)  CONSTRAINT [DF_Campus_ModifiedByUserID] DEFAULT ((-1)) NOT NULL,
    [ModifiedDate]     DATETIME      CONSTRAINT [DF_Campus_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Site] PRIMARY KEY CLUSTERED ([ID] ASC)
);




GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trgCampusHistoryRecord] ON  [dbo].[Campus] 
AFTER UPDATE AS 

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF(UPDATE(CODE) OR UPDATE(NAME) OR UPDATE(Address) OR UPDATE(Address2) OR UPDATE(CITY) OR UPDATE(ZipCode) OR UPDATE(IsActive))
    INSERT INTO CampusHistory ([CampusID], [Code], [Name], [Address] ,[Address2], [City], [ZipCode], [IsActive], [ModifiedByUserID], [ModifiedDate], [AuditDate])
	SELECT ID, Code, Name, Address, Address2, City, ZipCode, IsActive, ModifiedByUserID, ModifiedDate, GETDATE()
	FROM deleted

END