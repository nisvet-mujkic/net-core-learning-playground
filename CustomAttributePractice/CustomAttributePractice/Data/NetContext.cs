using CustomAttributePractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomAttributePractice.Data
{
    public class NetContext: DbContext
    {
        public NetContext(DbContextOptions<NetContext> options): base(options)
        {

        }

        public DbSet<Project> Project{ get; set; }
    }
}
