
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

[DataContract]
[Table("DevelopperProfiles")]
public class DevelopperProfile : Profile {

    [Key]
    [DataMember]
    public int DevID { get; set; }

    [DataMember]
    public virtual List<Technology> Technologies { get; set; }
}