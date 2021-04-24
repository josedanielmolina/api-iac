using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblTermohigrometro
    {
        public int Id { get; set; }
        public string Temperatura { get; set; }
        public string Humedad { get; set; }
        public int Frecuencia { get; set; }
    }
}
