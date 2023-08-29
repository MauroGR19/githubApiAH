using Microsoft.AspNetCore.Mvc;
using AppVenta.Aplicaciones.Interfaces;
using AppVenta.Dominio;
using AppVenta.Aplicaciones.Servicios;
using AppVenta.Infraestructura.Datos.Contextos;
using AppVenta.Infraestructura.Datos.Repositorios;
using AppProducto.Infraestructura.DTO.DTOs;
using AppProducto.Infraestructura.DTO.Mappers;
using static AppProducto.Aplicaciones.Maestras.Mensajes;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppVenta.Infraestructura.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
	public class ProductoController : ControllerBase
	{

		private readonly IServicioBase<Producto, Guid> db;
		public ProductoController(IServicioBase<Producto, Guid> _db)
		{
			db = _db;
		}

        // GET: api/<ProductoController>
        [HttpGet]
		public ActionResult<List<ProductoDTO>> Get()
		{
			return Ok(db.Listar().Map());
		}

		// GET api/<ProductoController>/5
		[HttpGet("{id}")]
		

		// POST api/<ProductoController>
		[HttpPost]
		public ActionResult Post([FromBody] ProductoDTO producto)
		{
			db.Agregar(producto.Map());
			return Ok(Satisfactorio.Insertado.GetEnumDescription());
		}

		// PUT api/<ProductoControlador>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ProductoControlador>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
