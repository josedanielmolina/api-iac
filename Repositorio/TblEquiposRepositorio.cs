namespace Repositorio
{

    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;

    using Modelos;
    using Dto;
    using Microsoft.EntityFrameworkCore;

    public class TblEquiposRepositorio
    {
        private readonly ApplicationDbContext _context;

        public TblEquiposRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProfundimetroDto>> ListarProfundimetros()
        {

            var dto = await (from equipos in _context.tbl_equipos
                             where equipos.Equipo == "Profundimetro"
                             select new ProfundimetroDto
                             {
                                 Llave = equipos.Serial,
                                 Valor = equipos.Id
                             }).ToListAsync();

            return dto;

        }
    }
}
