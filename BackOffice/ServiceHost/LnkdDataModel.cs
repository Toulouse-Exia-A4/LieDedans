namespace ServiceHost
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LnkdDataModel : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « LnkdDataModel » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « ServiceHost.LnkdDataModel » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « LnkdDataModel » dans le fichier de configuration de l'application.
        public LnkdDataModel()
            : base("name=LnkdDataModel")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<DevelopperProfile> DevelopperProfiles { get; set; }
        public virtual DbSet<ProjectChiefProfile> ProjectChiefProfiles { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}