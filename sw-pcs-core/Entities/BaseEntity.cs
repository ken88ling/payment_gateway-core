using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sw_pcs_core.Entities
{
    public class BaseEntity
    {
        [Key]
        public Int32 Id { get; set; }

        public DateTime CreatedOn { get; set; } 

        public DateTime ModifiedOn { get; set; }
    }
}
