using Academix.controlador;
using Academix.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Academix.negocio
{
    internal class AsistenciaMatriculadosN
    {
        AsistenciaMatriculadosC _asistenciaControlador;
        // Se elimina _allGradosDt y las listas hardcodeadas de grados

        public AsistenciaMatriculadosN()
        {
            _asistenciaControlador = new AsistenciaMatriculadosC();
            // Ya no se carga _allGradosDt al inicio
        }

        public string insertar(string idMatricula, DateTime fecha, string estado)
        {
            if (string.IsNullOrWhiteSpace(idMatricula))
            {
                throw new ArgumentException("El ID de matrícula no puede estar vacío.", nameof(idMatricula));
            }
            if (string.IsNullOrWhiteSpace(estado))
            {
                throw new ArgumentException("El estado de asistencia no puede estar vacío.", nameof(estado));
            }

            string newIdAsistencia = Guid.NewGuid().ToString();

            _asistenciaControlador.insert(new AsistenciaMatriculadosM(newIdAsistencia, idMatricula, fecha, estado));

            return newIdAsistencia;
        }

        public void modificar(string idAsistencia, string idMatricula, DateTime fecha, string estado)
        {
            if (string.IsNullOrWhiteSpace(idAsistencia))
            {
                throw new ArgumentException("El ID de asistencia no puede estar vacío para modificar.", nameof(idAsistencia));
            }
            if (string.IsNullOrWhiteSpace(idMatricula))
            {
                throw new ArgumentException("El ID de matrícula no puede estar vacío.", nameof(idMatricula));
            }
            if (string.IsNullOrWhiteSpace(estado))
            {
                throw new ArgumentException("El estado de asistencia no puede estar vacío.", nameof(estado));
            }

            _asistenciaControlador.update(new AsistenciaMatriculadosM(idAsistencia, idMatricula, fecha, estado));
        }

        public void eliminar(string idAsistenciaMatriculado)
        {
            if (string.IsNullOrWhiteSpace(idAsistenciaMatriculado))
            {
                throw new ArgumentException("El ID de asistencia no puede estar vacío para eliminar.", nameof(idAsistenciaMatriculado));
            }
            _asistenciaControlador.delete(idAsistenciaMatriculado);
        }

        public DataTable obtenerEstadosAsistenciaParaDGV()
        {
            return _asistenciaControlador.obtenerEstadosAsistenciaDataTable();
        }

        public void seleccionarNiveles(ComboBox combo)
        {
            _asistenciaControlador.selectNiveles(combo);
        }

        // *** NUEVO MÉTODO: Obtener ID de Grado del DB a partir de su nombre y nivel ***
        public string obtenerIdGrado(string nombreGrado, string nivel)
        {
            if (string.IsNullOrWhiteSpace(nombreGrado) || string.IsNullOrWhiteSpace(nivel))
            {
                return null;
            }
            return _asistenciaControlador.getGradoId(nombreGrado, nivel);
        }

        // *** NUEVO MÉTODO: Obtener ID de Sección del DB a partir de su nombre ***
        public string obtenerIdSeccion(string nombreSeccion)
        {
            if (string.IsNullOrWhiteSpace(nombreSeccion))
            {
                return null;
            }
            return _asistenciaControlador.getSeccionId(nombreSeccion);
        }

        // Se elimina obtenerGradosFiltradosPorNivel

        public void cargarMatriculadosConAsistencia(DataGridView dgv, string idGrado, string idSeccion, DateTime fechaAsistencia)
        {
            if (string.IsNullOrWhiteSpace(idGrado) || string.IsNullOrWhiteSpace(idSeccion))
            {
                dgv.DataSource = null;
                return;
            }
            _asistenciaControlador.selectMatriculadosConAsistenciaParaDGV(dgv, idGrado, idSeccion, fechaAsistencia);
        }
    }
}