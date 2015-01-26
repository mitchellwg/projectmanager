CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [Cost] DECIMAL(18, 2) NOT NULL, 
    [Description] NVARCHAR(1000) NOT NULL, 
    [IsPro] BIT NOT NULL, 
    [UserId] INT NOT NULL,
)
