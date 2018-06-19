
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

[DataContract]
public class User {

    [Key]
    public int ID { get; set; }

    [DataMember]
    [Column(TypeName = "VARCHAR")]
    [StringLength(50)]
    [Index(IsUnique =true)]
    public string Username { get; set; }

    [DataMember]
    public string Password { get; set; }

    public Profile Profile { get; set; }
}