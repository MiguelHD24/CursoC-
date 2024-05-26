using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Detalle_Compra
	{
		 public static Detalle_Compra Insert (Detalle_Compra Entidad)
		{
			 return DAL_Detalle_Compra.Insert(Entidad);
		}
		 public static bool Update (Detalle_Compra Entidad)
		{
			 return DAL_Detalle_Compra.Update(Entidad);
		}
		 public static bool Anular (Detalle_Compra Entidad)
		{
			 return DAL_Detalle_Compra.Anular(Entidad);
		}
		 public static bool Existe (Detalle_Compra Entidad)
		{
			 return DAL_Detalle_Compra.Existe(Entidad);
		}
		 public static Detalle_Compra Registro (Detalle_Compra Entidad)
		{
			 return DAL_Detalle_Compra.Registro(Entidad);
		}
		 public static List<Detalle_Compra> Lista (bool Activo = true)
		{
			 return DAL_Detalle_Compra.Lista(Activo);
		}
	}
}
