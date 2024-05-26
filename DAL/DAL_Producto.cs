using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Producto
	{
		 public static Producto Insert (Producto Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Producto.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Producto Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Producto.Find(Entidad.IdProducto);
				 Registro.Codigo = Entidad.Codigo;
				 Registro.Nombre = Entidad.Nombre;
				 Registro.Descripcion = Entidad.Descripcion;
				 Registro.IdCategoria = Entidad.IdCategoria;
				 Registro.Stock = Entidad.Stock;
				 Registro.PrecioCompra = Entidad.PrecioCompra;
				 Registro.PrecioVenta = Entidad.PrecioVenta;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Producto Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Producto.Find(Entidad.IdProducto);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Producto Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Producto.Where(a=>a.IdProducto == Entidad.IdProducto).Count() > 0;
			}
		}
		 public static Producto Registro (Producto Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Producto.Where(a=>a.IdProducto == Entidad.IdProducto).SingleOrDefault();
			}
		}
		 public static List<Producto> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Producto.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
