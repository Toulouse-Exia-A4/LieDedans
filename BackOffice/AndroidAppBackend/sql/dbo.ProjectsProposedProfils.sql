CREATE TABLE [dbo].[ProjectsProposedProfils] (
    [ProjectId] INT NOT NULL,
    [ProfilId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ProfilId] ASC, [ProjectId] ASC),
    CONSTRAINT [FK_ProjectsProposedProfils_Projects] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Projects] ([Id]),
    CONSTRAINT [FK_ProjectsProposedProfils_Profils] FOREIGN KEY ([ProfilId]) REFERENCES [dbo].[Profils] ([Id])
);

