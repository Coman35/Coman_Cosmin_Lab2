﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coman_Cosmin_Lab2.Models;

namespace Coman_Cosmin_Lab2.Data
{
    public class Coman_Cosmin_Lab2Context : DbContext
    {
        public Coman_Cosmin_Lab2Context (DbContextOptions<Coman_Cosmin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Coman_Cosmin_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Coman_Cosmin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Coman_Cosmin_Lab2.Models.Author> Author { get; set; } = default!;
    }
}