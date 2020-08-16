using gepeti.Context;
using gepeti.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gepeti.Repositories
{
    public class CabRepository : ICabRepository
    {
        private readonly AppDbContext _context;

        public CabRepository(AppDbContext contexto) // injeção do contexto para poder ter acesso ao EF
        {
            _context = contexto;
        }

        public Cab LerDadosEmpresa()
        {
            return _context.cab.FirstOrDefault();
        }

    }
}
