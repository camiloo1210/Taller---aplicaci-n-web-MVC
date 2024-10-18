using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller1.Models;

    public class TallerMVC : DbContext
    {
        public TallerMVC (DbContextOptions<TallerMVC> options)
            : base(options)
        {
        }

        public DbSet<Taller1.Models.Equipo> Equipo { get; set; } = default!;
    }
