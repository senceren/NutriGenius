﻿using NutriGenius.Data.Entities.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.SubClasses_Meal
{
    public class Lunch : Meal
    {
        public override string MealName => "Öğle Yemeği";
    }
}
