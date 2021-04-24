using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblPesos
    {
        public int Id { get; set; }
        public int Idplaca { get; set; }
        public int? Peso11 { get; set; }
        public int? Peso12 { get; set; }
        public int? Peso21 { get; set; }
        public int? Peso22 { get; set; }
        public int? Peso31 { get; set; }
        public int? Peso32 { get; set; }
        public int? Peso41 { get; set; }
        public int? Peso42 { get; set; }
        public int? Peso51 { get; set; }
        public int? Peso52 { get; set; }
        public int Operario { get; set; }
    }
}
