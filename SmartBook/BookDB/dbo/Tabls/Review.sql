CREATE TABLE [dbo].[Review]
(
	[ReviewId] INT NOT NULL PRIMARY KEY, 
    [BookId] INT NOT NULL, 
    [ReviewText] NCHAR(400) NOT NULL, 
    [ReviewRating] INT NOT NULL, 
    [ReviewDate] DATETIME NOT NULL, 
    [UserName] NVARCHAR(MAX) NOT NULL
)
