using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHost
{
    [DataContract]
    public class HttpResponse
    {
        [DataMember]
        public HttpStatusCode code;

        [DataMember]
        public string message;
    }
}
