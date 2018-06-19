using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceHost
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ILoginService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        [WebInvoke(
            Method="POST",
            ResponseFormat=WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "auth"
            )]
        User Login(User user);
    }
}
