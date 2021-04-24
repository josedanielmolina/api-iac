using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblLuces
    {
        public int Id { get; set; }
        public int Idprueba { get; set; }
        public int Idplaca { get; set; }
        public bool Farola { get; set; }
        public bool Luces { get; set; }
        public string Intensidad { get; set; }
        public string Inclinacion { get; set; }
        public int Operario { get; set; }
    }
}
