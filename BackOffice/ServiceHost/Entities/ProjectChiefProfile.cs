
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

[DataContract]
[Table("ChiefProfiles")]
public class ProjectChiefProfile : Profile {

    [Key]
    [DataMember]
    public int ChiefID { get; set; }

    [DataMember]
    public virtual List<Project> Projects{ get; set; }

}