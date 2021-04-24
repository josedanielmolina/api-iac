using System;

namespace Modelos
{
    public partial class TblUsuarios
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public int Nivel { get; set; }
        public int Habilitado { get; set; }
        public int Gases { get; set; }
        public int Alineacion { get; set; }
        public int Opacidad { get; set; }
        public int Visual { get; set; }
        public int Luces { get; set; }
        public int Frenos_Motos { get; set; }
        public int Frenos_Pesados { get; set; }
        public int Frenos_Livianos { get; set; }
        public int Fotografia { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaCambio { get; set; }
        public byte[] Firma { get; set; }
    }
}
