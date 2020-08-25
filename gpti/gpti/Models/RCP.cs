using System;
using System.ComponentModel.DataAnnotations;

namespace gpti.Models
{

    public class RCP
    {
        public double Id { get; set; }
        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Data { get; set; }
        [Display(Name = "Hora")]
        public string Hora { get; set; }
        [Display(Name = "Contato Interno")]
        public string ContInt { get; set; }
        [Display(Name = "Contato Externo")]
        public string ContExt { get; set; }
        [Display(Name = "Local")]
        public string Local { get; set; }
        [Display(Name = "Telefone")]
        public string TelCont { get; set; }
        [Display(Name = "Posição")]
        public string Posicao { get; set; }
        public string Tipo { get; set; }
        public string Ct { get; set; }
        public string Email { get; set; }
        public string Origem { get; set; }
    }
}
