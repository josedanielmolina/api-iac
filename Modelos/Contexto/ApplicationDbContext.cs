using System;
using Microsoft.EntityFrameworkCore;


namespace Modelos
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblVisualMotocicletas> tbl_visual_motocicletas { get; set; }
        public virtual DbSet<TblVisualLivPes> tbl_visual_liv_pes { get; set; }
        public virtual DbSet<TblVisualMotocarros> tbl_visual_motocarros { get; set; }
        public virtual DbSet<TblVisualRemolques> tbl_visual_remolques { get; set; }
        public virtual DbSet<TblPruebas> tbl_pruebas { get; set; }
        public virtual DbSet<TblVehiculos> tbl_vehiculos { get; set; }
        public virtual DbSet<TblListasPersonalizadas> tbl_listas_personalizadas { get; set; }
        public virtual DbSet<TblPruebaVisual> tbl_prueba_visual { get; set; }
        public virtual DbSet<TblEquipos> tbl_equipos { get; set; }
        public virtual DbSet<TblObservaciones> tbl_observaciones { get; set; }
        public virtual DbSet<TblAuditoriaSicov> tbl_auditoria_sicov { get; set; }
        public virtual DbSet<TblUsuarios> tbl_usuarios { get; set; }
        public virtual DbSet<TblListaMaestra> tbl_lista_maestra { get; set; }

    }
}
