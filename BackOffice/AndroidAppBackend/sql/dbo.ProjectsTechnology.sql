CREATE TABLE [dbo].[ProjectsTechnology] (
    [ProjectId] INT NOT NULL,
    [TechnologyId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ProjectId] ASC, [TechnologyId] ASC),
    CONSTRAINT [FK_ProjectsTechnology_Technology] FOREIGN KEY ([TechnologyId]) REFERENCES [dbo].[Technology] ([Id]),
    CONSTRAINT [FK_ProjectsTechnology_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Projects] ([Id])
);

