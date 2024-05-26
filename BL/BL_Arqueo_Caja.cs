using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Arqueo_Caja
	{
		 public static Arqueo_Caja Insert (Arqueo_Caja Entidad)
		{
			 return DAL_Arqueo_Caja.Insert(Entidad);
		}
		 public static bool Update (Arqueo_Caja Entidad)
		{
			 return DAL_Arqueo_Caja.Update(Entidad);
		}
		 public static bool Anular (Arqueo_Caja Entidad)
		{
			 return DAL_Arqueo_Caja.Anular(Entidad);
		}
		 public static bool Existe (Arqueo_Caja Entidad)
		{
			 return DAL_Arqueo_Caja.Existe(Entidad);
		}
		 public static Arqueo_Caja Registro (Arqueo_Caja Entidad)
		{
			 return DAL_Arqueo_Caja.Registro(Entidad);
		}
		 public static List<Arqueo_Caja> Lista (bool Activo = true)
		{
			 return DAL_Arqueo_Caja.Lista(Activo);
		}
	}
}
