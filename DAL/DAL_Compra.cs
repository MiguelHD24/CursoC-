using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Compra
	{
		 public static Compra Insert (Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.FechaRegistro = DateTime.Now;
				 Entidad.Activo = true;
				 bd.Compra.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Compra.Find(Entidad.IdCompra);
				 Registro.IdUsuario = Entidad.IdUsuario;
				 Registro.IdProveedor = Entidad.IdProveedor;
				 Registro.TipoDocumento = Entidad.TipoDocumento;
				 Registro.NumeroDocumento = Entidad.NumeroDocumento;
				 Registro.SubTotal = Entidad.SubTotal;
				 Registro.ImpuestoTotal = Entidad.ImpuestoTotal;
				 Registro.Total = Entidad.Total;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Compra.Find(Entidad.IdCompra);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Compra.Where(a=>a.IdCompra == Entidad.IdCompra).Count() > 0;
			}
		}
		 public static Compra Registro (Compra Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Compra.Where(a=>a.IdCompra == Entidad.IdCompra).SingleOrDefault();
			}
		}
		 public static List<Compra> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Compra.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
