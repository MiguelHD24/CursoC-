using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Permiso
	{
		 public static Permiso Insert (Permiso Entidad)
		{
			 return DAL_Permiso.Insert(Entidad);
		}
		 public static bool Update (Permiso Entidad)
		{
			 return DAL_Permiso.Update(Entidad);
		}
		 public static bool Anular (Permiso Entidad)
		{
			 return DAL_Permiso.Anular(Entidad);
		}
		 public static bool Existe (Permiso Entidad)
		{
			 return DAL_Permiso.Existe(Entidad);
		}
		 public static Permiso Registro (Permiso Entidad)
		{
			 return DAL_Permiso.Registro(Entidad);
		}
		 public static List<Permiso> Lista (bool Activo = true)
		{
			 return DAL_Permiso.Lista(Activo);
		}
	}
}
