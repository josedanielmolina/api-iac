using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblLinealidad
    {
        public int Id { get; set; }
        public string SerialAna { get; set; }
        public string FiltroCero { get; set; }
        public string ValorCero { get; set; }
        public string FiltroMedio1 { get; set; }
        public string ValorMedio1 { get; set; }
        public string FiltroMedio2 { get; set; }
        public string ValorMedio2 { get; set; }
        public string FiltroMedio3 { get; set; }
        public string ValorMedio3 { get; set; }
        public string FiltroCien { get; set; }
        public string Valor100 { get; set; }
        public string Resultado { get; set; }
        public string Tecnico { get; set; }
    }
}
