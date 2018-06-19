
using ServiceHost.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

[DataContract]
public class Project {


    public Project()
    {
        this.ProposedProfiles = new HashSet<Profile>();
        this.AcceptedProfiles = new HashSet<Profile>();
    }

    [Key]
    [DataMember]
    public int ID { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Description { get; set; }

    [Required]
    [DataMember]
    public ProjectChiefProfile ProjectChief { get; set; }

    [DataMember]
    public virtual ICollection<Profile> ProposedProfiles { get; set; }

    [DataMember]
    public virtual ICollection<Profile> AcceptedProfiles { get; set; }
}