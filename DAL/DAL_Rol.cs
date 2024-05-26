using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Rol
	{
		 public static Rol Insert (Rol Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.FechaRegistro = DateTime.Now;
				 Entidad.Activo = true;
				 bd.Rol.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Rol Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Rol.Find(Entidad.IdRol);
				 Registro.Descripcion = Entidad.Descripcion;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Rol Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Rol.Find(Entidad.IdRol);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Rol Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Rol.Where(a=>a.IdRol == Entidad.IdRol).Count() > 0;
			}
		}
		 public static Rol Registro (Rol Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Rol.Where(a=>a.IdRol == Entidad.IdRol).SingleOrDefault();
			}
		}
		 public static List<Rol> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Rol.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
