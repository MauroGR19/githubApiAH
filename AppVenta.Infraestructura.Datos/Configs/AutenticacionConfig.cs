using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProducto.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppProducto.Infraestructura.Datos.Configs
{
    public class AutenticacionConfig : IEntityTypeConfiguration<AutenticacionDominio>
    {
        public void Configure(EntityTypeBuilder<AutenticacionDominio> builder)
        {
            builder.ToTable("tblAdministradors");
            builder.HasKey(c => c.Correo);
            builder.HasKey(c => c.Contraseña);
        }
    }
}
