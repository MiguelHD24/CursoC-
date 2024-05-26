using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Rol
	{
		 public static Rol Insert (Rol Entidad)
		{
			 return DAL_Rol.Insert(Entidad);
		}
		 public static bool Update (Rol Entidad)
		{
			 return DAL_Rol.Update(Entidad);
		}
		 public static bool Anular (Rol Entidad)
		{
			 return DAL_Rol.Anular(Entidad);
		}
		 public static bool Existe (Rol Entidad)
		{
			 return DAL_Rol.Existe(Entidad);
		}
		 public static Rol Registro (Rol Entidad)
		{
			 return DAL_Rol.Registro(Entidad);
		}
		 public static List<Rol> Lista (bool Activo = true)
		{
			 return DAL_Rol.Lista(Activo);
		}
	}
}
