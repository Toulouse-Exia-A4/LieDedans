using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceHost
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ProjectService" à la fois dans le code et le fichier de configuration.
    public class ProjectService : IProjectService
    {
        public Project CreateProject(Project project)
        {
            using (var ctx = new LnkdDataModel())
            {
                project.ProjectChief = (ProjectChiefProfile)ctx.Profiles.Find(project.ProjectChief.Id);
                ctx.Projects.Add(project);
                ctx.SaveChanges();

                return project;
            }
        }
        

        public List<Profile> GetAcceptedProfilesLinkedToProject(string id)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProject()
        {
            using (var ctx = new LnkdDataModel())
            {
                return ctx.Projects.Include("ProjectChief").ToList();
            }
        }

        public Project GetProject(string id)
        {
            using(var ctx= new LnkdDataModel())
            {
                //Project project = ctx.Projects.Find(Int32.Parse(id));

                
                int ID = Int32.Parse(id);
                Project project = ctx.Projects.Include("ProjectChief").Where(b => b.ID == ID).First();

                if (project == null)
                {
                    throw new WebFaultException<string>("Projet introuvable",System.Net.HttpStatusCode.BadRequest);
                }

                return project;
            }
        }
        

        public List<Profile> GetProposedProfilesLinkedToProject(string id)
        {
            using (var ctx = new LnkdDataModel())
            {
                int ID = Int32.Parse(id);

                ctx.Projects.Include("ProjectChief").ToList();
                return null;
            }
        }


        public List<Technology> GetTechnologiesLinkedToProject(string id)
        {
            throw new NotImplementedException();
        }


        public List<Technology> GetTechnologiesSharedWithDev(string idProject, string idDev)
        {
            throw new NotImplementedException();
        }
    }
}
