﻿using CRUDWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.Data
{
    public class MvcStudentContext : DbContext
    {
        public MvcStudentContext(DbContextOptions<MvcStudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}