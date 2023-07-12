using NutriGenius.Data.Entities.Abstract_Class;
using NutriGenius.Data.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities
{
    public class SessionManager
    {
		private static User currentuser = null!;

		public static User CurrentUser
		{
			get { return currentuser; }
			set { currentuser = value; }
		}

		private static Meal currentMeal = null!;

		public static Meal CurrentMeal
		{
			get { return currentMeal; }
			set { currentMeal = value; }
		}


	}
}
