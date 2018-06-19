
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

public class DevelopperProfile : Profile {

    [Key]
    public int DevID { get; set; }

    [ForeignKey("Technology")]
    public virtual List<int> Technologies { get; set; }
}