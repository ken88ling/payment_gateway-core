using System;
using System.Collections.Generic;
using System.Text;

namespace sw_pcs_core.Entities
{
    public class User : BaseEntity
    {
        public Int64 AccountId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

    }
}
