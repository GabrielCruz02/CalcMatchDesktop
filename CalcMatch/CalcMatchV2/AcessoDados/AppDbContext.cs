using CalcMatchV1.Entities;
using CalcMatchV1.UI.FormsFilho;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcMatchV2;

namespace CalcMatchV2.AcessoDados
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOPDAELL;Database=BD_CalcMatch;Trusted_Connection=True;TrustServerCertificate=True");
            optionsBuilder.UseSqlite(@$"DataSource=E:\Projetos\CalcMatchV2\CalcMatchV2\app.db");
        }
        


        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }


    }
}
