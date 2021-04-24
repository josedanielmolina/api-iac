using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblResSonometro
    {
        public int Id { get; set; }
        public int Idprueba { get; set; }
        public string Ruidopito { get; set; }
        public string Ruidomotor { get; set; }
        public string Operario { get; set; }
        public int Equipo { get; set; }
        public string Mecanizada { get; set; }
        public string VersionApp { get; set; }
        public string Checksum { get; set; }
    }
}
