using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPISERVICELAYERPROJECT.Models;

namespace WebAPISERVICELAYERPROJECT.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPISERVICELAYERPROJECT.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
