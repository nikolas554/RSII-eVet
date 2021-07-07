using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Database
{
    public class Data
    {
        public static void Seed(VeterinarskaStanicaContext context)
        {
            context.Database.Migrate();
        }
    }
}
