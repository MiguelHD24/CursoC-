using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Producto
	{
		 public static Producto Insert (Producto Entidad)
		{
			 return DAL_Producto.Insert(Entidad);
		}
		 public static bool Update (Producto Entidad)
		{
			 return DAL_Producto.Update(Entidad);
		}
		 public static bool Anular (Producto Entidad)
		{
			 return DAL_Producto.Anular(Entidad);
		}
		 public static bool Existe (Producto Entidad)
		{
			 return DAL_Producto.Existe(Entidad);
		}
		 public static Producto Registro (Producto Entidad)
		{
			 return DAL_Producto.Registro(Entidad);
		}
		 public static List<Producto> Lista (bool Activo = true)
		{
			 return DAL_Producto.Lista(Activo);
		}
	}
}
