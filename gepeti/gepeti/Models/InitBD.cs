using gepeti.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gepeti.Models
{
    public class InitBD
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.cab.Any())
            {
                return;   //O BD foi alimentado
            }
        }
    }
}
