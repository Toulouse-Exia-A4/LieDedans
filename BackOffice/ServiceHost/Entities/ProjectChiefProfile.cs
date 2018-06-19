
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

public class ProjectChiefProfile : Profile {

    [Key]
    public int ChiefID { get; set; }

    [ForeignKey("Project")]
    public virtual List<int> ProjectIDs{ get; set; }

}