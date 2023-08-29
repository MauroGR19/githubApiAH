using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVenta.Dominio;
using AppVenta.Dominio.Interfaces.Repositorio;
using AppVenta.Aplicaciones.Interfaces;
using AppProducto.Aplicaciones.Maestras;
using static AppProducto.Aplicaciones.Maestras.Mensajes;

namespace AppVenta.Aplicaciones.Servicios
{
	public class ProductoServicio : IServicioBase<Producto, Guid>
	{

		private readonly IRepositorioBase<Producto> repoProducto;
		private Excepciones excepcion = new Excepciones();

		public ProductoServicio(IRepositorioBase<Producto> _repoProducto)
		{
			repoProducto = _repoProducto;
		}

		public Producto Agregar(Producto entidad)
		{
            try
            {
				var resultProducto = repoProducto.Agregar(entidad);
				repoProducto.guardarCambios();
				return resultProducto;
			}
            catch (Exception ex)
            {
				throw excepcion.Error(ex, Error.Agregar.GetEnumDescription());
            }

			
		}

		public List<Producto> Listar()
		{
			return repoProducto.Listar();
		}

		public Producto SeleccionarPorID(Guid entidadId)
		{
			throw new NotImplementedException();
		}
	}
}
