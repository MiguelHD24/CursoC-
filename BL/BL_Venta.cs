using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Venta
	{
		 public static Venta Insert (Venta Entidad)
		{
			 return DAL_Venta.Insert(Entidad);
		}
		 public static bool Update (Venta Entidad)
		{
			 return DAL_Venta.Update(Entidad);
		}
		 public static bool Anular (Venta Entidad)
		{
			 return DAL_Venta.Anular(Entidad);
		}
		 public static bool Existe (Venta Entidad)
		{
			 return DAL_Venta.Existe(Entidad);
		}
		 public static Venta Registro (Venta Entidad)
		{
			 return DAL_Venta.Registro(Entidad);
		}
		 public static List<Venta> Lista (bool Activo = true)
		{
			 return DAL_Venta.Lista(Activo);
		}
	}
}
