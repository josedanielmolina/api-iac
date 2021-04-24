using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblResultadoEncuesta
    {
        public int Id { get; set; }
        public int Idprueba { get; set; }
        public int Pregunta1 { get; set; }
        public int Pregunta2 { get; set; }
        public int Pregunta3 { get; set; }
        public int Pregunta4 { get; set; }
        public int Pregunta5 { get; set; }
        public int Pregunta6 { get; set; }
    }
}
