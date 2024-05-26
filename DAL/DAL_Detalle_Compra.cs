using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Detalle_Compra
	{
		 public static Detalle_Compra Insert (Detalle_Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Detalle_Compra.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Detalle_Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Detalle_Compra.Find(Entidad.IdDetalleCompra);
				 Registro.IdCompra = Entidad.IdCompra;
				 Registro.IdProducto = Entidad.IdProducto;
				 Registro.PrecioCompra = Entidad.PrecioCompra;
				 Registro.PrecioVenta = Entidad.PrecioVenta;
				 Registro.Cantidad = Entidad.Cantidad;
				 Registro.SubTotal = Entidad.SubTotal;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Detalle_Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Detalle_Compra.Find(Entidad.IdDetalleCompra);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Detalle_Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Detalle_Compra.Where(a=>a.IdDetalleCompra == Entidad.IdDetalleCompra).Count() > 0;
			}
		}
		 public static Detalle_Compra Registro (Detalle_Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Detalle_Compra.Where(a=>a.IdDetalleCompra == Entidad.IdDetalleCompra).SingleOrDefault();
			}
		}
		 public static List<Detalle_Compra> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
			}
		}
	}
}
