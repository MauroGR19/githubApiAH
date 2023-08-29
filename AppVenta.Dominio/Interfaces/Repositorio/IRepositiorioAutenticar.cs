using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVenta.Dominio.Interfaces;
namespace AppProducto.Dominio.Interfaces.Repositorio
{
    public interface IRepositiorioAutenticar<TEntidad, TEntidaID>
        :IAgregar<TEntidad>, ITransaccion
    {
        TEntidad obtenerAutenticacion(TEntidad Correo, TEntidaID Contraseña);
    }
}
