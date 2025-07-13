using Academix.modelo;
using ESTRES.dao;
using System;
using System.Data;

namespace Academix.controlador
{
    internal class AsistenciaMatriculadosC
    {
        conexion x;

        public AsistenciaMatriculadosC()
        {
            x = new conexion();
        }

        public void insert(AsistenciaMatriculadosM dato)
        {
            string fechaFormatoDB = dato.Fecha.ToString("s");
            x.manipular("INSERT INTO asistencias_matriculados (id, id_matricula, fecha, estado) VALUES ('" + dato.Id + "', '" + dato.IdMatricula + "', '" + fechaFormatoDB + "', '" + dato.Estado + "')");
        }

        public void update(AsistenciaMatriculadosM dato)
        {
            string fechaFormatoDB = dato.Fecha.ToString("s");
            x.manipular("UPDATE asistencias_matriculados SET id_matricula='" + dato.IdMatricula + "', fecha='" + fechaFormatoDB + "', estado='" + dato.Estado + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(string idAsistenciaMatriculado)
        {
            x.manipular("DELETE FROM asistencias_matriculados WHERE id = '" + idAsistenciaMatriculado + "'");
        }

        public void deleteAsistenciasByFilters(string idGrado, string idSeccion, DateTime fecha)
        {
            string fechaFormatoDB = fecha.ToString("yyyy-MM-dd");
            x.manipular("DELETE FROM asistencias_matriculados WHERE id_matricula IN (SELECT id FROM matriculas WHERE id_grado = '" + idGrado + "' AND id_seccion = '" + idSeccion + "') AND CAST(fecha AS DATE) = CAST('" + fechaFormatoDB + "' AS DATE)");
        }

        public DataTable obtenerEstadosAsistenciaDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("estado", typeof(string));
            dt.Rows.Add("A", "Asistió");
            dt.Rows.Add("T", "Tardanza");
            dt.Rows.Add("F", "Falta");
            return dt;
        }

        public DataTable cargarTodosMatriculadosConAsistencia(DateTime fechaAsistencia)
        {
            string fechaSql = fechaAsistencia.ToString("yyyy-MM-dd");
            return x.manipular("SELECT m.id AS id_matricula, u.nombres + ' ' + u.ape_paterno + ' ' + u.ape_materno AS nombre_completo_estudiante, g.nombres AS grado_nombre, s.nombre AS seccion_nombre, g.nivel AS nivel_nombre, am.id AS id_asistencia_existente, ISNULL(am.estado, '') AS estado_asistencia FROM matriculas m JOIN estudiantes e ON m.id_estudiante = e.id JOIN usuarios u ON e.id_usuario = u.id JOIN grados g ON m.id_grado = g.id JOIN secciones s ON m.id_seccion = s.id LEFT JOIN asistencias_matriculados am ON m.id = am.id_matricula AND (am.fecha IS NULL OR CAST(am.fecha AS DATE) = CAST('" + fechaSql + "' AS DATE))");
        }
    }
}
