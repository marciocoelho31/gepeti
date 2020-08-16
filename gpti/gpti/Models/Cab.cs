using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gpti.Models
{

    public class Cab
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string DadosContato { get; set; }
    }
}
