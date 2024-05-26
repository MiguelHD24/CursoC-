using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Proveedor
	{
		 public static Proveedor Insert (Proveedor Entidad)
		{
			 return DAL_Proveedor.Insert(Entidad);
		}
		 public static bool Update (Proveedor Entidad)
		{
			 return DAL_Proveedor.Update(Entidad);
		}
		 public static bool Anular (Proveedor Entidad)
		{
			 return DAL_Proveedor.Anular(Entidad);
		}
		 public static bool Existe (Proveedor Entidad)
		{
			 return DAL_Proveedor.Existe(Entidad);
		}
		 public static Proveedor Registro (Proveedor Entidad)
		{
			 return DAL_Proveedor.Registro(Entidad);
		}
		 public static List<Proveedor> Lista (bool Activo = true)
		{
			 return DAL_Proveedor.Lista(Activo);
		}
	}
}
