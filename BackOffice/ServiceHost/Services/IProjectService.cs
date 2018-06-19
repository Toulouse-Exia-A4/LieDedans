using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceHost
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IProjectService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IProjectService
    {
        [OperationContract]
        [WebInvoke(Method ="GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "{id}")]
        Project GetProject(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "create")]
        Project CreateProject(Project project);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "technologies/{id}")]
        List<Technology> GetTechnologiesLinkedToProject(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "proposedProfiles/{id}")]
        List<Profile> GetProposedProfilesLinkedToProject(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "acceptedProfiles/{id}")]
        List<Profile> GetAcceptedProfilesLinkedToProject(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "all")]
        List<Project> GetAllProject();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "sharedTechnologiesWithDev/{idProject}/{idDev}")]
        List<Technology> GetTechnologiesSharedWithDev(string idProject,string idDev);

    
        




    }


}
