using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
//using Oracle.EntityFrameworkCore;
using AppVenta.Dominio;
using AppVenta.Infraestructura.Datos.Configs;

namespace AppVenta.Infraestructura.Datos.Contextos
{
	public class ProductoContexto : DbContext
	{
		public DbSet<Producto> Productos { get; set; }

		//public DbSet<Autenticacion> Autenticacino { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer("Data Source=LAPTOP-B0U91KVL\\SQLEXPRESS;Initial Catalog=Producto;Integrated Security=True; Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new ProductoConfig());

		}
	}
}
