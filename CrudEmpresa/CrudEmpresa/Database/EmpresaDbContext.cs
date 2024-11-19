using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using CrudEmpresa.Models;

namespace CrudEmpresa.Database
{
    public class EmpresaDbContext : DbContext
    {
        public EmpresaDbContext() : base("DbConnection")
        {
        }

        public DbSet<Empresa> Empresa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}