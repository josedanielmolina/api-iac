using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblAnalizadorGases
    {
        public int Id { get; set; }
        public string Pef { get; set; }
        public string SerieBench { get; set; }
        public string SerieEquipo { get; set; }
        public string MarcaAna { get; set; }
        public string VerSoftware { get; set; }
        public string NomSoftware { get; set; }
        public string SpanBajoHc { get; set; }
        public string SpanBajoCo { get; set; }
        public string SpanBajoCo2 { get; set; }
        public string SpanAltoHc { get; set; }
        public string SpanAltoCo { get; set; }
        public string SpanAltoCo2 { get; set; }
        public string Dedicacion { get; set; }
    }
}
