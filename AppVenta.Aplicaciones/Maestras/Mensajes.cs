using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProducto.Aplicaciones.Maestras
{
    public static class Mensajes
    {
        public enum Satisfactorio
        {
            [Description("Agregar satisfactoriamente!!!!!")]
            Insertado,
           
        }

        public enum Error
        {
            [Description("No se pudo insertar, verifique que los datos estén correctos")]
            Agregar,
            
        }

        public static string GetEnumDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
        }
    }
}
