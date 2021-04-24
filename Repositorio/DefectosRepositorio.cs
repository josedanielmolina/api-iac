namespace Repositorio
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    using Modelos;
    using Dto;

    public class DefectosRepositorio
    {
        private readonly ApplicationDbContext _context;

        public DefectosRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DefectoDto>> ConsultarDefectosMotocicleta()
        {
            var dto = await (from defectosmotos in _context.tbl_visual_motocicletas
                             select new DefectoDto
                             {
                                 Id = defectosmotos.Id,
                                 Defecto = defectosmotos.Defecto,
                                 Fatal = defectosmotos.Fatal,
                                 Codigo = defectosmotos.Codigo,
                                 Codigov2 = defectosmotos.Codigov2,
                                 Grupo = defectosmotos.Grupo
                             }).ToListAsync();

            return dto;
        }

        public async Task<List<DefectoDto>> ConsultarDefectosLivanosPesados()
        {
            var dto = await (from defectosmotos in _context.tbl_visual_liv_pes
                             select new DefectoDto
                             {
                                 Id = defectosmotos.Id,
                                 Defecto = defectosmotos.Defecto,
                                 Fatal = defectosmotos.Fatal,
                                 Codigo = defectosmotos.Codigo,
                                 Codigov2 = defectosmotos.Codigov2,
                                 Grupo = defectosmotos.Grupo
                             }).ToListAsync();

            return dto;
        }

        public async Task<List<DefectoDto>> ConsultarDefectosMotocarro()
        {
            var dto = await (from defectosmotos in _context.tbl_visual_motocarros
                             select new DefectoDto
                             {
                                 Id = defectosmotos.Id,
                                 Defecto = defectosmotos.Defecto,
                                 Fatal = defectosmotos.Fatal,
                                 Codigo = defectosmotos.Codigo,
                                 Codigov2 = defectosmotos.Codigov2,
                                 Grupo = defectosmotos.Grupo
                             }).ToListAsync();

            return dto;
        }

        public async Task<List<DefectoDto>> ConsultarDefectosRemolques()
        {
            var dto = await (from defectosmotos in _context.tbl_visual_remolques
                             select new DefectoDto
                             {
                                 Id = defectosmotos.Id,
                                 Defecto = defectosmotos.Defecto,
                                 Fatal = defectosmotos.Fatal,
                                 Codigo = defectosmotos.Codigo,
                                 Codigov2 = defectosmotos.Codigov2,
                                 Grupo = defectosmotos.Grupo
                             }).ToListAsync();

            return dto;
        }
    }
}
