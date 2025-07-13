using Academix.modelo;
using ESTRES.dao;
using System.Data;
using System.Windows.Forms;
using System;

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
            string fechaFormatoDB = dato.Fecha.ToString("yyyy-MM-dd");
            x.manipular("INSERT INTO asistencias_matriculados (id, id_matricula, fecha, estado) VALUES ('" + dato.Id + "', '" + dato.IdMatricula + "', CONVERT(DATETIME, '" + fechaFormatoDB + "', 120), '" + dato.Estado + "')");
        }

        public void update(AsistenciaMatriculadosM dato)
        {
            string fechaFormatoDB = dato.Fecha.ToString("yyyy-MM-dd");
            x.manipular("UPDATE asistencias_matriculados SET id_matricula='" + dato.IdMatricula + "', fecha=CONVERT(DATETIME, '" + fechaFormatoDB + "', 120), estado='" + dato.Estado + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(string idAsistenciaMatriculado)
        {
            x.manipular("DELETE FROM asistencias_matriculados WHERE id ='" + idAsistenciaMatriculado + "'");
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

        public void selectNiveles(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT DISTINCT nivel FROM grados  ORDER BY nivel");
            combo.DataSource = dt;
            combo.DisplayMember = "nivel";
            combo.ValueMember = "nivel";
            combo.SelectedIndex = -1;
        }

        // *** NUEVO MÉTODO: Obtener ID de Grado por Nombre y Nivel ***
        public string getGradoId(string nombreGrado, string nivel)
        {
            // Se asume que el nombre del grado y el nivel son únicos para obtener un ID.
            DataTable dt = x.manipular("SELECT id FROM grados WHERE nombres = '" + nombreGrado + "' AND nivel = '" + nivel + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["id"].ToString();
            }
            return null; // O lanzar una excepción si el grado no existe
        }

        // *** NUEVO MÉTODO: Obtener ID de Sección por Nombre ***
        public string getSeccionId(string nombreSeccion)
        {
            DataTable dt = x.manipular("SELECT id FROM secciones WHERE nombre = '" + nombreSeccion + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["id"].ToString();
            }
            return null; // O lanzar una excepción si la sección no existe
        }

        public void selectMatriculadosConAsistenciaParaDGV(DataGridView dgv, string idGrado, string idSeccion, DateTime fechaAsistencia)
        {
            string fechaSql = fechaAsistencia.ToString("yyyy-MM-dd");

            string query = "SELECT m.id AS id_matricula, u.nombres + ' ' + u.ape_paterno + ' ' + u.ape_materno AS nombre_completo_estudiante, am.id AS id_asistencia_existente, ISNULL(am.estado, '') AS estado_asistencia FROM matriculas m JOIN estudiantes e ON m.id_estudiante = e.id JOIN usuarios u ON e.id_usuario = u.id LEFT JOIN asistencias_matriculados am ON m.id = am.id_matricula AND CONVERT(DATE, am.fecha) = CONVERT(DATE, '" + fechaSql + "', 120) WHERE m.id_grado = '" + idGrado + "' AND m.id_seccion = '" + idSeccion + "'";

            dgv.DataSource = x.manipular(query);
        }
    }
}