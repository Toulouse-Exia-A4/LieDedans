CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] VARCHAR(20) NOT NULL, 
    [Password] VARCHAR(MAX) NOT NULL, 
    [Profil] INT NULL, 
    CONSTRAINT [FK_User_Profil] FOREIGN KEY ([Profil]) REFERENCES [Profils]([Id]) ON DELETE CASCADE, 
    CONSTRAINT [CK_User_Username] UNIQUE(Username)
)
