using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVenta.Dominio;
using AppVenta.Dominio.Interfaces.Repositorio;
using AppVenta.Infraestructura.Datos.Contextos;

namespace AppVenta.Infraestructura.Datos.Repositorios
{
	public class ProductoRepositorio : IRepositorioBase<Producto>
	{

		private ProductoContexto db;

		public ProductoRepositorio(ProductoContexto _db)
		{
			db = _db;
		}

		public Producto Agregar(Producto entidad)
		{
			entidad.productoId = Guid.NewGuid();
			//aca es donde se mapea la entidad
			db.Productos.Add(entidad);
			return entidad;
		}

        public void guardarCambios()
        {
			db.SaveChanges();
		}

		public List<Producto> Listar()
		{
			return db.Productos.ToList();
		}

	}
}
