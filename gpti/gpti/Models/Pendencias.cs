using System;

namespace gpti.Models
{

    public class Pendencias
    {
        public int Id { get; set; }
        public int? Prior { get; set; }
        public string Tipo { get; set; }
        public string Cliente { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataSolic { get; set; }
        public string Posicao { get; set; }
        public DateTime? DataPos { get; set; }
        public string HoraPos { get; set; }
        public string QuemSolic { get; set; }
        public string FormaSolic { get; set; }
        public string ComentInt { get; set; }
        public string Sistema { get; set; }
        public string Usuario { get; set; }
        public DateTime? Previsao { get; set; }
        public int Minutos { get; set; }
        public int QtdDias { get; set; }
        public DateTime? DtLanc { get; set; }
        public string Prog { get; set; }
        public int NovoItem { get; set; }
        public int Urgente { get; set; }
        public string NaWeb { get; set; }
        public string Projeto { get; set; }
        public string DescricaoOrig { get; set; }
    }
}
