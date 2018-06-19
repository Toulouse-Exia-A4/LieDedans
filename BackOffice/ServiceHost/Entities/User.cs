
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

[DataContract]
public class User {

    [Key]
    public int ID { get; set; }

    [DataMember]
    public string Username { get; set; }

    [DataMember]
    public string Password { get; set; }

    public Profile Profile { get; set; }
}