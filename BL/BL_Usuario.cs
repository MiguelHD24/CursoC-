using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Usuario
	{
		 public static Usuario Insert (Usuario Entidad)
		{
			 return DAL_Usuario.Insert(Entidad);
		}
		 public static bool Update (Usuario Entidad)
		{
			 return DAL_Usuario.Update(Entidad);
		}
		 public static bool Anular (Usuario Entidad)
		{
			 return DAL_Usuario.Anular(Entidad);
		}
		 public static bool Existe (Usuario Entidad)
		{
			 return DAL_Usuario.Existe(Entidad);
		}
		 public static Usuario Registro (Usuario Entidad)
		{
			 return DAL_Usuario.Registro(Entidad);
		}
		 public static List<Usuario> Lista (bool Activo = true)
		{
			 return DAL_Usuario.Lista(Activo);
		}
	}
}
