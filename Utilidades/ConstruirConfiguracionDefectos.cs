//namespace Utilidades
//{
//    using System.Collections.Generic;
//    using System.Linq;

//    using Dto;

//    public class ConstruirConfiguracionDefectos
//    {
//        public ConfiguracionListaDto ConstruirListas(List<SeccionDeserializadaDto> secciones, List<DefectoDto> defectos)
//        {
//            /* Construimos una lista con objetos que incluye el nombre de la seccion y los defectos asociados a esta*/
//            List<SeccionDto> defectosAplican = new List<SeccionDto>();

//            foreach (var seccion in secciones)
//            {
//                var grupoDefecto = new SeccionDto();

//                grupoDefecto.NombreSeccion = seccion.NombreSeccion;

//                var lista = new List<DefectoDto>();

//                foreach (var codigo in seccion.DefectosAsociados)
//                {
//                    var getDefecto = defectos.FirstOrDefault(x => x.Id == codigo);

//                    if (getDefecto != null)
//                    {
//                        lista.Add(getDefecto);
//                    }

//                    grupoDefecto.DefectosAsociados = lista;
//                }

//                defectosAplican.Add(grupoDefecto);
//            }

//            /* Obtener defectos no aplican */
//            var codigos = new List<int>();

//            foreach (var pestana in secciones)
//            {
//                foreach (var codigo in pestana.DefectosAsociados)
//                {
//                    codigos.Add(codigo);
//                }
//            }

//            var defectosNoAplican = defectos.ToList();

//            foreach (var codigo in codigos)
//            {
//                defectosNoAplican.RemoveAll(x => x.Id == codigo);
//            }

//            var dto = new ConfiguracionListaDto()
//            {
//                DefectosAplican = defectosAplican,
//                DefectosNoAplican = defectosNoAplican
//            };

//            return dto;

//        }





//    }
//}
