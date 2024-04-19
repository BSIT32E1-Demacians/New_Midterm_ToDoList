﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo> ToDoSet { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
