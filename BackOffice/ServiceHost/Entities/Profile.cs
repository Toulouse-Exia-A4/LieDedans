
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

[DataContract]
public class Profile
{

    public Profile()
    {
        this.ProposedProjects = new HashSet<Project>();
        this.AcceptedProjects = new HashSet<Project>();
    }

    [Key]
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string ContactDetails { get; set; }

    [DataMember]
    public virtual ICollection<Project> ProposedProjects { get; set; }

    [DataMember]
    public virtual ICollection<Project> AcceptedProjects { get; set; }


}