
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

public class Project {

    [Key]
    public int ID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    [Required]
    public ProjectChiefProfile ProjectChief { get; set; }

    [ForeignKey("Profile")]
    public virtual List<int> ProposedProfileIDs { get; set; }

    [ForeignKey("Profile")]
    public virtual List<int> AcceptedProfileIDs { get; set; }
}