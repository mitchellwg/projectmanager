CREATE TABLE [dbo].[Lesson]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PC] NVARCHAR(50) NOT NULL, 
    [Title] NVARCHAR(250) NOT NULL, 
    [Remarks] NVARCHAR(1000) NOT NULL, 
    [CreatedDate] DATETIME NOT NULL, 
    [ProjectId] INT NOT NULL, 
    [PhaseId] INT NOT NULL
)
