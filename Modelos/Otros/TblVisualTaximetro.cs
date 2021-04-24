﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblVisualTaximetro
    {
        public int Id { get; set; }
        public string Defecto { get; set; }
        public int Fatal { get; set; }
        public string Codigo { get; set; }
        public string Grupo { get; set; }
    }
}
