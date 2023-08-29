using System;

using AppVenta.Infraestructura.Datos.Contextos;

namespace AppVenta.Infraestructura.Datos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Creando la DB si no existe...");
			ProductoContexto db = new ProductoContexto();
			db.Database.EnsureCreated();
			Console.WriteLine("Listo!!!!!");
			Console.ReadKey();
		}
	}
}
