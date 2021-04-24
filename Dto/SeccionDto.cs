namespace Dto
{
    using System.Collections.Generic;

    public class SeccionDto
    {
        public string NombreSeccion { get; set; }
        public List<DefectoDto> DefectosAsociados { get; set; }
    }
}
