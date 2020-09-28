using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelos;
namespace Data
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             //"Data Source=SQL5046.site4now.net;" +
             //"Initial Catalog=DB_A4FD02_prueba1234567;User Id=DB_A4FD02_prueba1234567_admin;Password=d_link2010.;");
             "Data Source=.; Initial Catalog=PruebaSodexo; Integrated Security=True;");
            //"Data Source=sql5032.site4now.net;" +
            //    "Initial Catalog=DB_A53E0A_ConfeccionesPrueba;User Id=DB_A53E0A_ConfeccionPrueba_admin;Password=d-link2010.;");
            base.OnConfiguring(optionsBuilder);
            //Primer Migracion   Add-Migration InitialCreate

            //Despues de la primera migracion se utiliza  Update-Database
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Inpuesto> inpuestos { get; set; }
        public DbSet<Facturacion> Facturacion { get; set; }
    }
}
