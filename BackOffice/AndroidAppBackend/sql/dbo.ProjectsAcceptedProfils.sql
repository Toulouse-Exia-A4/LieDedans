CREATE TABLE [dbo].[ProjectsAcceptedProfils] (
    [ProjectId] INT NOT NULL,
    [ProfilId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ProfilId] ASC, [ProjectId] ASC),
    CONSTRAINT [FK_ProjectsAcceptedProfils_Projects] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Projects] ([Id]),
    CONSTRAINT [FK_ProjectsAcceptedProfils_Profils] FOREIGN KEY ([ProfilId]) REFERENCES [dbo].[Profils] ([Id])
);

