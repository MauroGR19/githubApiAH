using System.ComponentModel.DataAnnotations;

namespace AppProducto.Infraestructura.DTO.DTOs
{
    public class ProductoDTO
    {
		public Guid productoId { get; set; }
		[Required]
		public string nombre { get; set; }
		[Required]
		public string descripcion { get; set; }
		[Required]
		public decimal costo { get; set; }
		[Required]
		public decimal precio { get; set; }
		[Required]
		public decimal cantidadEnStock { get; set; }
	}
}
