using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Proveedor
	{
		 public static Proveedor Insert (Proveedor Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Proveedor.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Proveedor Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Proveedor.Find(Entidad.IdProveedor);
				 Registro.Documento = Entidad.Documento;
				 Registro.RazonSocial = Entidad.RazonSocial;
				 Registro.Correo = Entidad.Correo;
				 Registro.Telefono = Entidad.Telefono;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Proveedor Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Proveedor.Find(Entidad.IdProveedor);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Proveedor Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Proveedor.Where(a=>a.IdProveedor == Entidad.IdProveedor).Count() > 0;
			}
		}
		 public static Proveedor Registro (Proveedor Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Proveedor.Where(a=>a.IdProveedor == Entidad.IdProveedor).SingleOrDefault();
			}
		}
		 public static List<Proveedor> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Proveedor.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
