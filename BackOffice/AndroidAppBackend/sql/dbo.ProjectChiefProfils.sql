CREATE TABLE [dbo].[ProjectChiefProfils] (
    [Id]         INT           NOT NULL,
    [ProfilKey]  INT           NOT NULL,
    [Experience] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_ProjectChiefProfils_ProfilKey] UNIQUE NONCLUSTERED ([ProfilKey] ASC),
    CONSTRAINT [FK_ProjectChiefProfils_Profil] FOREIGN KEY ([ProfilKey]) REFERENCES [dbo].[Profils] ([Id]) ON DELETE CASCADE
);

