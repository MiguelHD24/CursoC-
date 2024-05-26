using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Negocio
	{
		 public static Negocio Insert (Negocio Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 bd.Negocio.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Negocio Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Negocio.Find(Entidad.IdNegocio);
				 Registro.Nombre = Entidad.Nombre;
				 Registro.RUC = Entidad.RUC;
				 Registro.Direccion = Entidad.Direccion;
				 Registro.Logo = Entidad.Logo;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Negocio Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Negocio.Find(Entidad.IdNegocio);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Negocio Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Negocio.Where(a=>a.IdNegocio == Entidad.IdNegocio).Count() > 0;
			}
		}
		 public static Negocio Registro (Negocio Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Negocio.Where(a=>a.IdNegocio == Entidad.IdNegocio).SingleOrDefault();
			}
		}
		 public static List<Negocio> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
			}
		}
	}
}
