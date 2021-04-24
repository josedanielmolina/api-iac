using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblFotos
    {
        public int Id { get; set; }
        public string NombreArchivo { get; set; }
        public int LongArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public int Idturno { get; set; }
        public int EstFoto { get; set; }
        public string Operario { get; set; }
        public string VersionApp { get; set; }
    }
}
