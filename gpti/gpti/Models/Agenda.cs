using System;
using System.ComponentModel.DataAnnotations;

namespace gpti.Models
{

    public class Agenda
    {
        public int Id { get; set; }
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
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Posição")]
        public string Tipo { get; set; }
        [Display(Name = "Minutos")]
        public string Minutos { get; set; }
        [Display(Name = "Tempo de Deslocamento")]
        public string TempoDesloc { get; set; }
        [Display(Name = "Resolvido em")]
        public DateTime? Resolvido_Data { get; set; }
        [Display(Name = "")]
        public string Resolvido_Hora { get; set; }
    }
}
