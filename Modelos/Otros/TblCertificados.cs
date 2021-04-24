using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblCertificados
    {
        public int Id { get; set; }
        public int Certificado { get; set; }
        public string Estado { get; set; }
        public string Placa { get; set; }
        public string Motivo { get; set; }
    }
}
