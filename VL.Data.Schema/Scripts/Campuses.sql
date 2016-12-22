--Seed Campust
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
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (1, 'Director Conference Room', 2, '2129', '9164643400', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 2 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (2, 'Cedar Conference Room', 1, '1119', '9164643500', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 3 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (3, 'Evergreen Conference Room', 2, '2250', '9164644109', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 4 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (4, 'Executive Conference Room', 2, '2242', '9164643400', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 5 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (5, 'Isbell Conference Room', 1, NULL, '9164640619', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 6 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (6, 'Maple Conference Room', 2, '2248', '9164644107', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 7 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (7, 'Redwood Conference Room', 1, '1134', '9164644330', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 8 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (8, 'Sequoia Conference Room', 2, '2249', '9164644108', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 9 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (9, 'Walnut Conference Room', 2, '2251', '9164644110', 1)
--Seed Locations : Prospect Green 1
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 10 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (10, 'Asilomar Conference Room', 2, '205', '9164315492', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 11 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (11, 'Huntington Conference Room', 3, '302', '9164315499', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 12 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (12, 'La Jolla Computer Lab', 3, '319', '9164315515', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 13 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (13, 'Malibu Conference Room', 3, '321', '9164315497', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 14 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (14, 'Monterey Conference Room', 2, '203', '9164315496', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 15 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (15, 'Redondo Conference Room', 3, '323', '9164315498', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 16 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (16, 'Santa Monica Conference Room', 3, '317', '9164315494', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 17 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (17, 'Seaside Conference Room', 4, '401', '9164315495', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 18 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (18, 'Stinson Conference Room', 4, '423', '9164315514', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 19 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (19, 'Venice Conference Room', 4, '416', '9164315512', 1)
--Seed Locations : Prospect Green 3
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 20 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (20, 'Capistrano Conference Room', 3, '361', '9164316281', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 21 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (21, 'Capitola Conference Room', 3, '332', '9164316578', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 22 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (22, 'Carmel Conference Room', 3, '333', '9164316579', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 23 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (23, 'Catalina Conference Room', 3, '331', '9164316250', 1)
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = 24 ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [IsActive]) 
	VALUES (24, 'Coronado Conference Room', 3, '330', '9164316244', 1)


--Seed CampusLocation : Gold Camp 
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 1 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 1)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 2 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 2)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 3 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 3)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 4 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 4)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 5 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 5)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 6 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 6)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 7 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 7)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 8 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 8)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 1 AND LocationID = 9 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (1, 9)
--Seed CampusLocation : Prospect Green 1
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 10 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 10)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 11 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 11)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 12 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 12)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 13 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 13)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 14 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 14)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 15 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 15)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 16 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 16)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 17 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 17)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 18 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 18)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 3 AND LocationID = 19 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (3, 19)
--Seed CampusLocation : Prospect Green 3
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 4 AND LocationID = 20 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (4, 20)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 4 AND LocationID = 21 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (4, 21)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 4 AND LocationID = 22 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (4, 22)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 4 AND LocationID = 23 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (4, 23)
IF ((SELECT COUNT(1) FROM [dbo].[CampusLocation] WHERE CampusID = 4 AND LocationID = 24 ) = 0 ) 
	INSERT INTO [dbo].[CampusLocation] ([CampusID], [LocationID]) 
	VALUES (4, 24)

































/*
IF ((SELECT COUNT(1) FROM [dbo].[Location] WHERE ID = '<ID>' ) = 0 ) 
	INSERT INTO [dbo].[Location] ([ID], [Name], [Floor], [Room], [Phone], [Address], [City], [ZipCode], [IsActive]) 
	VALUES ('<ID>', '<Name>', '<Floor>', '<Room>', '<Phone>', '<IsActive>')
*/
SET IDENTITY_INSERT [dbo].[Location] OFF 

--Seed CampusLocation : 
/*Gold Camp*/


