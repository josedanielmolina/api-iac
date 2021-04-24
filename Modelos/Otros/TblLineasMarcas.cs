using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblLineasMarcas
    {
        public int Id { get; set; }
        public int CodigoWs { get; set; }
        public int CodigoMarca { get; set; }
        public int CodigoLinea { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
    }
}
