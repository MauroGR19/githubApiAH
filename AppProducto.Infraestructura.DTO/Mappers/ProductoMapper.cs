using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProducto.Infraestructura.DTO.DTOs;
using AppVenta.Dominio;

namespace AppProducto.Infraestructura.DTO.Mappers
{
    public static class ProductoMapper
    {
        public static ProductoDTO Map(this Producto model)
        {
            return new ProductoDTO()
            {
                productoId = model.productoId,
                nombre = model.nombre,
                descripcion = model.descripcion,
                costo = model.costo,
                precio = model.precio,
                cantidadEnStock = model.cantidadEnStock,
            };
        }

        public static List<ProductoDTO> Map(this List<Producto> model)
        {
            List<ProductoDTO> Dtos = new List<ProductoDTO>();

            foreach (Producto modelItem in model)
            {
                Dtos.Add(Map(modelItem));
            }

            return Dtos;
        }

        public static Producto Map(this ProductoDTO DTO)
        {
            return new Producto()
            {
                productoId = DTO.productoId,
                nombre = DTO.nombre,
                descripcion = DTO.descripcion,
                costo = DTO.costo,
                precio = DTO.precio,
                cantidadEnStock = DTO.cantidadEnStock,

            };
        }
    }
}
