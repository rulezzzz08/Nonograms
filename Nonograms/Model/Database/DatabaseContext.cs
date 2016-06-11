﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonograms.Model.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<NonogramInfo> NonogramsInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Progress.db");
        }
    }
}
