using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Categoria
	{
		 public static Categoria Insert (Categoria Entidad)
		{
			 return DAL_Categoria.Insert(Entidad);
		}
		 public static bool Update (Categoria Entidad)
		{
			 return DAL_Categoria.Update(Entidad);
		}
		 public static bool Anular (Categoria Entidad)
		{
			 return DAL_Categoria.Anular(Entidad);
		}
		 public static bool Existe (Categoria Entidad)
		{
			 return DAL_Categoria.Existe(Entidad);
		}
		 public static Categoria Registro (Categoria Entidad)
		{
			 return DAL_Categoria.Registro(Entidad);
		}
		 public static List<Categoria> Lista (bool Activo = true)
		{
			 return DAL_Categoria.Lista(Activo);
		}
	}
}
