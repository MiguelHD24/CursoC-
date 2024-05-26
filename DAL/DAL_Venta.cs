using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Venta
	{
		 public static Venta Insert (Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.FechaRegistro = DateTime.Now;
				 Entidad.Activo = true;
				 bd.Venta.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Venta.Find(Entidad.IdVenta);
				 Registro.IdUsuario = Entidad.IdUsuario;
				 Registro.IdCliente = Entidad.IdCliente;
				 Registro.IdMetodoPago = Entidad.IdMetodoPago;
				 Registro.TipoDocumento = Entidad.TipoDocumento;
				 Registro.NumeroDocumento = Entidad.NumeroDocumento;
				 Registro.DocumentoCliente = Entidad.DocumentoCliente;
				 Registro.NombreCliente = Entidad.NombreCliente;
				 Registro.SubTotal = Entidad.SubTotal;
				 Registro.ImpuestoTotal = Entidad.ImpuestoTotal;
				 Registro.MontoPago = Entidad.MontoPago;
				 Registro.MontoCambio = Entidad.MontoCambio;
				 Registro.MontoTotal = Entidad.MontoTotal;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Venta.Find(Entidad.IdVenta);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Venta.Where(a=>a.IdVenta == Entidad.IdVenta).Count() > 0;
			}
		}
		 public static Venta Registro (Venta Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Venta.Where(a=>a.IdVenta == Entidad.IdVenta).SingleOrDefault();
			}
		}
		 public static List<Venta> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Venta.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
