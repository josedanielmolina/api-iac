﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblListaDefectosEstver
    {
        public int Id { get; set; }
        public string Estacion { get; set; }
        public string Linea { get; set; }
        public string Equipo { get; set; }
        public string Defecto { get; set; }
    }
}
