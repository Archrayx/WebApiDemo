Use ApiTestDb
GO
DROP TABLE [dbo].[Quote]
GO
CREATE TABLE [dbo].[Quote](
[QuoteId] int identity(1,1) PRIMARY KEY,
[QuoteType] varchar(20),
[Contact] varchar (20),
[Task] varchar(250),
[DueDate] Date null,
[TaskType] varchar(20)
)

GO 
Insert [dbo].[Quote]( QuoteType, Contact, Task, DueDate, TaskType) Values('BEST','Sales King','Prepares quotes for others', null, 'Documenter') 
Insert [dbo].[Quote]( QuoteType, Contact, Task, DueDate, TaskType) Values('Average','Sales Aprenticed','random task Description', null, 'apprentice') 

