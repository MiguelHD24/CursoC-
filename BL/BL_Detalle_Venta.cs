using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Detalle_Venta
	{
		 public static Detalle_Venta Insert (Detalle_Venta Entidad)
		{
			 return DAL_Detalle_Venta.Insert(Entidad);
		}
		 public static bool Update (Detalle_Venta Entidad)
		{
			 return DAL_Detalle_Venta.Update(Entidad);
		}
		 public static bool Anular (Detalle_Venta Entidad)
		{
			 return DAL_Detalle_Venta.Anular(Entidad);
		}
		 public static bool Existe (Detalle_Venta Entidad)
		{
			 return DAL_Detalle_Venta.Existe(Entidad);
		}
		 public static Detalle_Venta Registro (Detalle_Venta Entidad)
		{
			 return DAL_Detalle_Venta.Registro(Entidad);
		}
		 public static List<Detalle_Venta> Lista (bool Activo = true)
		{
			 return DAL_Detalle_Venta.Lista(Activo);
		}
	}
}
