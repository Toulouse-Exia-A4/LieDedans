CREATE TABLE [dbo].[DevelopersTechnology] (
    [DeveloperId] INT NOT NULL,
    [TechnologyId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([DeveloperId] ASC, [TechnologyId] ASC),
    CONSTRAINT [FK_DevelopersTechnology_Technology] FOREIGN KEY ([TechnologyId]) REFERENCES [dbo].[Technology] ([Id]),
    CONSTRAINT [FK_DevelopersTechnology_Developer] FOREIGN KEY ([DeveloperId]) REFERENCES [dbo].[DeveloperProfils] ([Id])
);

