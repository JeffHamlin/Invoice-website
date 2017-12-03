﻿CREATE TABLE [dbo].[invoice]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [title] NCHAR(100) NOT NULL, 
    [created] DATETIME2 NULL DEFAULT (GETDATE()), 
    [updated] DATETIME2 NULL DEFAULT CURRENT_TIMESTAMP
	
	
)