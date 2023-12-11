using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacMP.Models;

namespace SacMP.Data
{
    public class SacMPContext : DbContext
    {
        public SacMPContext (DbContextOptions<SacMPContext> options)
            : base(options)
        {
        }

        public DbSet<SacMP.Models.MeetingPlan> MeetingPlan { get; set; } = default!;
    }
}
