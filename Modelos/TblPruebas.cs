
namespace Modelos
{
    public partial class TblPruebas
    {
        public int Id { get; set; }
        public int Idplaca { get; set; }
        public int Estado { get; set; }
        public int Idcliente { get; set; }
        public int Ultimaprueba { get; set; }
        public int Visual { get; set; }
        public int Luces { get; set; }
        public int Gases { get; set; }
        public int Opacimetro { get; set; }
        public int Desviacion { get; set; }
        public int Frenos { get; set; }
        public int Suspension { get; set; }
        public int Taximetro { get; set; }
        public int Sonometro { get; set; }
        public int Linea { get; set; }
        public string Certificado { get; set; }
        public bool Needluces { get; set; }
        public bool Needgases { get; set; }
        public bool Needvisual { get; set; }
        public bool Needopacimetro { get; set; }
        public bool Needfrenos { get; set; }
        public bool Needsuspension { get; set; }
        public bool Needdesviacion { get; set; }
        public bool Needtaximetro { get; set; }
        public bool Needsonometro { get; set; }
        public bool Foto { get; set; }
        public int Numeroprueba { get; set; }
        public int ConsecutivoRunt { get; set; }
        public int IdEntidad { get; set; }
        public int IdAnalizador { get; set; }
        public string TempAmbiente { get; set; }
        public string HumRelativa { get; set; }
        public string CausaAborto { get; set; }
        public string Resultado { get; set; }
        public string Aceite { get; set; }
        public int TipoPrueba { get; set; }
        public string CedInspector { get; set; }
        public string CaracterPrueba { get; set; }
        public string Factura { get; set; }
        public byte EstadoSicov { get; set; }
        public string Pin { get; set; }
        public string Respofirma { get; set; }
        public int IdVerificacion { get; set; }
        public byte EstadoSicov2 { get; set; }
        public int IdTarifa { get; set; }
        public string Mecanizada { get; set; }
        public string LugarMedicion { get; set; }
        public string IdRh { get; set; }
        public string IdRpm { get; set; }
        public byte ConsolidadoFur { get; set; }
        public int ConsecutivoRtm { get; set; }
        public byte Placaprueba { get; set; }
        public string IdTemp { get; set; }
    }
}
