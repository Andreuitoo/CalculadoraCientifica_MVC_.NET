using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CalculadoraCientifica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalculadoraCientifica.Data
{
    public class CalculadoraContext : DbContext
    {
        public DbSet<Calculadora> Calculos { get; set; }

        public CalculadoraContext(DbContextOptions<CalculadoraContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calculadora>().Property(f => f.CalcId).ValueGeneratedOnAdd(); ;
        }
    }
}
