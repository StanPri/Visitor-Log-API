--Seed Campuses First
SET IDENTITY_INSERT [dbo].[Campus] ON 
IF ((SELECT COUNT(1) FROM [dbo].[Campus] WHERE ID = 1 ) = 0 ) 
	INSERT INTO [dbo].[Campus] ([ID], [Code], [Name], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (1,'GCC', 'Gold Camp', '3101 Gold Camp Drive', 'Rancho Cordova', '95670', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Campus] WHERE ID = 2 ) = 0 ) 
	INSERT INTO [dbo].[Campus] ([ID], [Code], [Name], [Address], [Address2], [City], [ZipCode], [IsActive]) 
	VALUES (2,'HQ', 'J Street Building', '1325 J Street', 'Suite 1600', 'Sacramento', '95670', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Campus] WHERE ID = 3 ) = 0 ) 
	INSERT INTO [dbo].[Campus] ([ID], [Code], [Name], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (3,'PG1', 'Prospect Green 1', '10860 Gold Center Drive', 'Rancho Cordova', '95670', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Campus] WHERE ID = 4 ) = 0 ) 
	INSERT INTO [dbo].[Campus] ([ID], [Code], [Name], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (4,'PG3', 'Prospect Green 3', '10911 White Rock Road', 'Rancho Cordova', '95670', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Campus] WHERE ID = 5 ) = 0 ) 
	INSERT INTO [dbo].[Campus] ([ID], [Code], [Name], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (5,'CROY', 'Croydon Warehouse', '10173 Croydon Way', 'Sacramento', '95827', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Campus] WHERE ID = 6 ) = 0 ) 
	INSERT INTO [dbo].[Campus] ([ID], [Code], [Name], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (6,'VACA', 'Vacaville Data Center', '123 Main Streets', 'Vacaville', '55555', 1)
SET IDENTITY_INSERT [dbo].[Campus] OFF

--Seed Locations : Gold Camp
SET IDENTITY_INSERT [dbo].[Location] ON 
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 1 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (1, 'Director Conferenc Room', 2, '2129', '9164643400', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 2 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (2, 'Cedar Conference Room', 1, '1119', '9164643500', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 3 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (3, 'Evergreen Conference Room', 2, '2250', '9164644109', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 4 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (4, 'Execitove Conference Room', 2, '2242', '9164643400', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 5 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (5, 'Isbell', 1, NULL, '9164640619', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 6 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (6, 'Maple Conference Room', 2, '2248', '9164644107', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 7 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (7, 'Redwood Conference Room', 1, '1134', '9164644330', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 8 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (8, 'Sequoia Conference Room', 2, '2249', '9164644108', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 9 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES (9, 'Walnut Conference Room', 2, '2251', '9164644110', 1)
/*
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = '<ID>' ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES ('<ID>', '<Name>', '<Floor>', '<Room>', '<Phone>', '<IsActive>')
*/
SET IDENTITY_INSERT [dbo].[Location] OFF 

--Seed CampusLocation : 
/*Gold Camp*/


