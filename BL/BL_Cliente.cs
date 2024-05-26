using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Cliente
	{
		 public static Cliente Insert (Cliente Entidad)
		{
			 return DAL_Cliente.Insert(Entidad);
		}
		 public static bool Update (Cliente Entidad)
		{
			 return DAL_Cliente.Update(Entidad);
		}
		 public static bool Anular (Cliente Entidad)
		{
			 return DAL_Cliente.Anular(Entidad);
		}
		 public static bool Existe (Cliente Entidad)
		{
			 return DAL_Cliente.Existe(Entidad);
		}
		 public static Cliente Registro (Cliente Entidad)
		{
			 return DAL_Cliente.Registro(Entidad);
		}
		 public static List<Cliente> Lista (bool Activo = true)
		{
			 return DAL_Cliente.Lista(Activo);
		}
	}
}
