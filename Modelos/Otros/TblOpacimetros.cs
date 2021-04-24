using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblOpacimetros
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string MarcaOpa { get; set; }
        public string Software { get; set; }
        public string Version { get; set; }
        public string Firmware { get; set; }
        public string Dedicacion { get; set; }
        public string Ltoe { get; set; }
    }
}
