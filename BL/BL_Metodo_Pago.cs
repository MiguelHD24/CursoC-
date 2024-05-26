using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Metodo_Pago
	{
		 public static Metodo_Pago Insert (Metodo_Pago Entidad)
		{
			 return DAL_Metodo_Pago.Insert(Entidad);
		}
		 public static bool Update (Metodo_Pago Entidad)
		{
			 return DAL_Metodo_Pago.Update(Entidad);
		}
		 public static bool Anular (Metodo_Pago Entidad)
		{
			 return DAL_Metodo_Pago.Anular(Entidad);
		}
		 public static bool Existe (Metodo_Pago Entidad)
		{
			 return DAL_Metodo_Pago.Existe(Entidad);
		}
		 public static Metodo_Pago Registro (Metodo_Pago Entidad)
		{
			 return DAL_Metodo_Pago.Registro(Entidad);
		}
		 public static List<Metodo_Pago> Lista (bool Activo = true)
		{
			 return DAL_Metodo_Pago.Lista(Activo);
		}
	}
}
