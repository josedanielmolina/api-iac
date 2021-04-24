using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblSonometro
    {
        public int Id { get; set; }
        public int Idprueba { get; set; }
        public int Operario { get; set; }
        public int? Motor { get; set; }
    }
}
