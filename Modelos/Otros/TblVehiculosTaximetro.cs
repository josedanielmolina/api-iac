using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblVehiculosTaximetro
    {
        public int Id { get; set; }
        public int Idplaca { get; set; }
        public string Banderazo { get; set; }
        public string Unidadsegundos { get; set; }
        public string Unidadmetros { get; set; }
        public string Preciosegundos { get; set; }
        public string Preciometros { get; set; }
        public int Idprueba { get; set; }
        public string Errordistancia { get; set; }
        public string Errortiempo { get; set; }
        public int Operario { get; set; }
        public int Equipo { get; set; }
        public string Mecanizada { get; set; }
        public string Checksum { get; set; }
        public string VersionApp { get; set; }
    }
}
