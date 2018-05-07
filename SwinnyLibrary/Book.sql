CREATE TABLE [dbo].[Book]
(
	[ISBN] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Title] VARCHAR(50) NULL, 
    [Year] INT NULL, 

	[StudentId] NVARCHAR(50) NULL,
	[AuthorId] VARCHAR(5) NOT NULL,

    CONSTRAINT [FK_Book_Student] FOREIGN KEY ([StudentId]) REFERENCES [Student]([StudentId]),
	CONSTRAINT [FK_Book_Author] FOREIGN KEY ([AuthorId]) REFERENCES [Author]([AuthorId])

)
