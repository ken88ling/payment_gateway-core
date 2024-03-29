﻿using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

using sw_pcs_core.Entities;

namespace sw_pcs_core
{
    public class CoreContext : DbContext 
    {
        public DbSet<User> User { get; set; }

        public CoreContext (DbContextOptions<CoreContext> options) : base(options)
        {

        }
        
    }
}
