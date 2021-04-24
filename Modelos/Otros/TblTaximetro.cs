using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblTaximetro
    {
        public int Id { get; set; }
        public int Idprueba { get; set; }
        public int Recorridometros { get; set; }
        public int Recorridosegundos { get; set; }
        public decimal Taximetrometros { get; set; }
        public decimal Taximetrosegundos { get; set; }
        public int Unidadmetros { get; set; }
        public int Unidadsegundos { get; set; }
        public decimal Preciometros { get; set; }
        public decimal Preciosegundos { get; set; }
        public decimal Calculadometros { get; set; }
        public decimal Calculadosegundos { get; set; }
        public int Operario { get; set; }
        public decimal Banderazo { get; set; }
    }
}
