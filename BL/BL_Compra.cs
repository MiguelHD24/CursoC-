using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Compra
	{
		 public static Compra Insert (Compra Entidad)
		{
			 return DAL_Compra.Insert(Entidad);
		}
		 public static bool Update (Compra Entidad)
		{
			 return DAL_Compra.Update(Entidad);
		}
		 public static bool Anular (Compra Entidad)
		{
			 return DAL_Compra.Anular(Entidad);
		}
		 public static bool Existe (Compra Entidad)
		{
			 return DAL_Compra.Existe(Entidad);
		}
		 public static Compra Registro (Compra Entidad)
		{
			 return DAL_Compra.Registro(Entidad);
		}
		 public static List<Compra> Lista (bool Activo = true)
		{
			 return DAL_Compra.Lista(Activo);
		}
	}
}
