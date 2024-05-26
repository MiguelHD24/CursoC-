using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Cliente
	{
		 public static Cliente Insert (Cliente Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Cliente.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Cliente Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Cliente.Find(Entidad.IdCliente);
				 Registro.Documento = Entidad.Documento;
				 Registro.NombreCompleto = Entidad.NombreCompleto;
				 Registro.Correo = Entidad.Correo;
				 Registro.Telefono = Entidad.Telefono;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Cliente Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Cliente.Find(Entidad.IdCliente);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualiza = Entidad.FechaActualiza;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Cliente Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Cliente.Where(a=>a.IdCliente == Entidad.IdCliente).Count() > 0;
			}
		}
		 public static Cliente Registro (Cliente Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Cliente.Where(a=>a.IdCliente == Entidad.IdCliente).SingleOrDefault();
			}
		}
		 public static List<Cliente> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Cliente.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
