using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVenta.Dominio.Interfaces;

namespace AppVenta.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioBase<TEntidad>
        : IAgregar<TEntidad>, IListar<TEntidad>, ITransaccion
    {
        List<Producto> Listar();
    }
}
