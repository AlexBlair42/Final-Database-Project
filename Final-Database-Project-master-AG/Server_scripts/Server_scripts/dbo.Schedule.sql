CREATE TABLE [dbo].[Schedule]
(
	[schedule_id] INT NOT NULL PRIMARY KEY, 
    [movie_id] INT NULL, 
    [theatre_id] INT NULL, 
    [date] DATE NULL, 
    [time] TIME(1) NULL
)
