using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Negocio
	{
		 public static Negocio Insert (Negocio Entidad)
		{
			 return DAL_Negocio.Insert(Entidad);
		}
		 public static bool Update (Negocio Entidad)
		{
			 return DAL_Negocio.Update(Entidad);
		}
		 public static bool Anular (Negocio Entidad)
		{
			 return DAL_Negocio.Anular(Entidad);
		}
		 public static bool Existe (Negocio Entidad)
		{
			 return DAL_Negocio.Existe(Entidad);
		}
		 public static Negocio Registro (Negocio Entidad)
		{
			 return DAL_Negocio.Registro(Entidad);
		}
		 public static List<Negocio> Lista (bool Activo = true)
		{
			 return DAL_Negocio.Lista(Activo);
		}
	}
}
