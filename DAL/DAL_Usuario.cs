using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Usuario
	{
		 public static Usuario Insert (Usuario Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Usuario.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Usuario Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Usuario.Find(Entidad.IdUsuario);
				 Registro.Documento = Entidad.Documento;
				 Registro.NombreCompleto = Entidad.NombreCompleto;
				 Registro.Correo = Entidad.Correo;
				 Registro.Login = Entidad.Login;
				 Registro.Clave = Entidad.Clave;
				 Registro.IdRol = Entidad.IdRol;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Usuario Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Usuario.Find(Entidad.IdUsuario);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Usuario Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Usuario.Where(a=>a.IdUsuario == Entidad.IdUsuario).Count() > 0;
			}
		}
		 public static Usuario Registro (Usuario Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Usuario.Where(a=>a.IdUsuario == Entidad.IdUsuario).SingleOrDefault();
			}
		}
		 public static List<Usuario> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Usuario.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
