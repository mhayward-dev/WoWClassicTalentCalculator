﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace VanillaReborn.DataAccess
{
    public static class DbInitialiser
    {
        public static void Initialise(WoWClassicNewsContext context)
        {
            context.Database.EnsureCreated();

            if (!context.WarcraftClasses.Any())
            {
                DbSeeder.Seed(context);
            }
        }
    }
}