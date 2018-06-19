
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

[DataContract]
public class Technology {

    [Key]
    [DataMember]
    public int ID { get; set; }

    [DataMember]
    public string Name { get; set; }
}