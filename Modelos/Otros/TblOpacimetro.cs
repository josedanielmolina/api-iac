using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblOpacimetro
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Absorcion { get; set; }
        public string Rate { get; set; }
        public int Idprueba { get; set; }
        public int Operario { get; set; }
        public string Ciclo1 { get; set; }
        public string Ciclo2 { get; set; }
        public string Ciclo3 { get; set; }
        public string Ciclo4 { get; set; }
    }
}
