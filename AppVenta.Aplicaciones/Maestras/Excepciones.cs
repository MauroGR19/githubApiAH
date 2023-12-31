﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace AppProducto.Aplicaciones.Maestras
{
    public class Excepciones
    {

        public Exception Error(Exception ex, string _Mensaje)
        {
            //El ex va a funcionar para el Log
            string strMensaje = _Mensaje;

            try
            {
            }
            catch (ArgumentNullException)
            {
                strMensaje = strMensaje + ", Valores nulos";
            }
            catch (DirectoryNotFoundException)
            {
                strMensaje = strMensaje + ", El directorio no es válido";
            }
            catch (FormatException)
            {
                strMensaje = strMensaje + ", El formato no es válido";
            }
            catch (TimeoutException)
            {
                strMensaje = strMensaje + ", El intervalo de tiempo asignado a una operación ha expirado.";
            }
            catch (AuthenticationException)
            {
                strMensaje = strMensaje + ", Es necesario autenticarse";
            }
            catch (ValidationException)
            {
                strMensaje = strMensaje + ", Error de validación";
            }

            strMensaje = strMensaje + ", Detalle del error: " + ex.Message;

            throw new Exception(strMensaje);
        }
    }
}
