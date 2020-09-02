using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure_tp3.Models;

namespace Azure_tp3.Data
{
    public class Azure_tp3Context : DbContext
    {
        public Azure_tp3Context (DbContextOptions<Azure_tp3Context> options)
            : base(options)
        {
        }

        public DbSet<Azure_tp3.Models.Amigo> Amigo { get; set; }
    }
}
