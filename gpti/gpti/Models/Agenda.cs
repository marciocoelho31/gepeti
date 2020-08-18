using System;

namespace gpti.Models
{

    public class Agenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string ContInt { get; set; }
        public string ContExt { get; set; }
        public string Local { get; set; }
        public string TelCont { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Minutos { get; set; }
        public string TempoDesloc { get; set; }
        public DateTime? Resolvido_Data { get; set; }
        public string Resolvido_Hora { get; set; }
    }
}
