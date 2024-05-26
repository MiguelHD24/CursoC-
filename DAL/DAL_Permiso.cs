using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Permiso
	{
		 public static Permiso Insert (Permiso Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.FechaRegistro = DateTime.Now;
				 Entidad.Activo = true;
				 bd.Permiso.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Permiso Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Permiso.Find(Entidad.IdPermiso);
				 Registro.IdRol = Entidad.IdRol;
				 Registro.NombreMenu = Entidad.NombreMenu;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Permiso Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Permiso.Find(Entidad.IdPermiso);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Permiso Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Permiso.Where(a=>a.IdPermiso == Entidad.IdPermiso).Count() > 0;
			}
		}
		 public static Permiso Registro (Permiso Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Permiso.Where(a=>a.IdPermiso == Entidad.IdPermiso).SingleOrDefault();
			}
		}
		 public static List<Permiso> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Permiso.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
