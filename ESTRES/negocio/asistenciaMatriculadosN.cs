using Academix.controlador;
using Academix.modelo;
using System;
using System.Data;

namespace Academix.negocio
{
    internal class AsistenciaMatriculadosN
    {
        private AsistenciaMatriculadosC _asistenciaC;

        public AsistenciaMatriculadosN()
        {
            _asistenciaC = new AsistenciaMatriculadosC();
        }

        public string insertar(string idMatricula, DateTime fecha, string estado)
        {
            if (string.IsNullOrEmpty(idMatricula) || fecha == DateTime.MinValue || string.IsNullOrEmpty(estado))
            {
                throw new ArgumentException("ID de matrícula, fecha y estado son requeridos para insertar asistencia.");
            }
            string newId = Guid.NewGuid().ToString();
            AsistenciaMatriculadosM dato = new AsistenciaMatriculadosM(newId, idMatricula, fecha, estado);
            _asistenciaC.insert(dato);
            return newId;
        }

        public void modificar(string idAsistencia, string idMatricula, DateTime fecha, string estado)
        {
            if (string.IsNullOrEmpty(idAsistencia) || string.IsNullOrEmpty(idMatricula) || fecha == DateTime.MinValue || string.IsNullOrEmpty(estado))
            {
                throw new ArgumentException("ID de asistencia, ID de matrícula, fecha y estado son requeridos para modificar asistencia.");
            }
            AsistenciaMatriculadosM dato = new AsistenciaMatriculadosM(idAsistencia, idMatricula, fecha, estado);
            _asistenciaC.update(dato);
        }

        public void eliminar(string idAsistencia)
        {
            if (string.IsNullOrEmpty(idAsistencia))
            {
                throw new ArgumentException("ID de asistencia es requerido para eliminar.");
            }
            _asistenciaC.delete(idAsistencia);
        }

        public void eliminarAsistenciasPorFiltros(string idGrado, string idSeccion, DateTime fecha)
        {
            if (string.IsNullOrEmpty(idGrado) || string.IsNullOrEmpty(idSeccion) || fecha == DateTime.MinValue)
            {
                throw new ArgumentException("ID de grado, ID de sección y fecha son requeridos para eliminar asistencias por filtro.");
            }
            _asistenciaC.deleteAsistenciasByFilters(idGrado, idSeccion, fecha);
        }

        public DataTable obtenerEstadosAsistenciaParaDGV()
        {
            return _asistenciaC.obtenerEstadosAsistenciaDataTable();
        }

        public DataTable cargarTodosMatriculadosConAsistencia(DateTime fechaAsistencia)
        {
            return _asistenciaC.cargarTodosMatriculadosConAsistencia(fechaAsistencia);
        }
    }
}