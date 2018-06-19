CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[ProjectChiefId] INT NOT NULL,
    [Name] VARCHAR(50) NOT NULL, 
	[Description] VARCHAR(MAX) NULL,
    CONSTRAINT [AK_Projects_ProjectChiefId] UNIQUE ([ProjectChiefId]), 
    CONSTRAINT [FK_Projects_ProjectChiefId] FOREIGN KEY ([ProjectChiefId]) REFERENCES [ProjectChiefProfils]([Id])
)
