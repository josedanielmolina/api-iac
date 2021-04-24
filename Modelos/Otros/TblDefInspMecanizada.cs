using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblDefInspMecanizada
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Codigov2 { get; set; }
        public string Descripcion { get; set; }
        public string Grupo { get; set; }
        public string Tipo { get; set; }
        public int Imprimir { get; set; }
    }
}
