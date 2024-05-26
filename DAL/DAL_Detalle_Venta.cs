using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Detalle_Venta
	{
		 public static Detalle_Venta Insert (Detalle_Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Detalle_Venta.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Detalle_Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Detalle_Venta.Find(Entidad.IdDetalleVenta);
				 Registro.IdVenta = Entidad.IdVenta;
				 Registro.IdProducto = Entidad.IdProducto;
				 Registro.PrecioVenta = Entidad.PrecioVenta;
				 Registro.Cantidad = Entidad.Cantidad;
				 Registro.SubTotal = Entidad.SubTotal;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Detalle_Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Detalle_Venta.Find(Entidad.IdDetalleVenta);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Detalle_Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Detalle_Venta.Where(a=>a.IdDetalleVenta == Entidad.IdDetalleVenta).Count() > 0;
			}
		}
		 public static Detalle_Venta Registro (Detalle_Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Detalle_Venta.Where(a=>a.IdDetalleVenta == Entidad.IdDetalleVenta).SingleOrDefault();
			}
		}
		 public static List<Detalle_Venta> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
			}
		}
	}
}
