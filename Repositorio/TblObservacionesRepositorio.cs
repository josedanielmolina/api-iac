namespace Repositorio
{

    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;

    using Modelos;
    using Dto;
    using Microsoft.EntityFrameworkCore;

    public class TblObservacionesRepositorio
    {
        private readonly ApplicationDbContext _context;

        public TblObservacionesRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ObservacionDto>> ListarObservaciones()
        {

            var dto = await (from observaciones in _context.tbl_observaciones
                             select new ObservacionDto
                             {
                                 Id = observaciones.Id,
                                 Observaciones = observaciones.Observaciones
                             }).ToListAsync();

            return dto;

        }
    }
}
