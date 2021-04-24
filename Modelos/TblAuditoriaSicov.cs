using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Modelos
{
    public partial class TblAuditoriaSicov
    {
        [Key]
        [Required]
        [Column(TypeName = "INT(10)")]
        public int Id_Auditoria_Sicov { get; set; }

        public int Id_Revision { get; set; }
        public string Serial_Equipo_Medicion { get; set; }
        public string Ip_Equipo_Medicion { get; set; }
        public string Fecha_Registro_Bd { get; set; }
        public string Fecha_Evento { get; set; }
        public int Tipo_Operacion { get; set; }
        public int Tipo_Evento { get; set; }
        public int Codigo_Proveedor { get; set; }
        public int Id_Runt_Cda { get; set; }
        public string Trama { get; set; }
        public string Identificacion_Usuario { get; set; }
        public string Observacion { get; set; }
        public string Placa { get; set; }
    }
}
