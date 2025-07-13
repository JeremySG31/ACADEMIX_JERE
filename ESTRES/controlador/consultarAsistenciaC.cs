using ESTRES.dao;
using System.Data;
using System;
using System.Windows.Forms; 

namespace Academix.controlador
{
    internal class ConsultarAsistenciaC
    {
        private conexion x;

        public ConsultarAsistenciaC()
        {
            x = new conexion();
        }

        public void ConsultarHistorialAsistenciasPorFecha(DataGridView dgv, DateTime fecha)
        {
            string fechaFormatoDB = fecha.ToString("yyyy-MM-dd");

            dgv.DataSource = x.manipular("SELECT " +"m.id AS id_matricula, " + "u.nombres + ' ' + u.nombres + ' ' + u.ape_paterno + ' ' + u.ape_materno AS nombre_completo_estudiante, " +"am.fecha AS fecha_asistencia, " +
                                       "am.estado AS estado_asistencia " +"FROM asistencias_matriculados am " +"JOIN matriculas m ON am.id_matricula = m.id " +"JOIN estudiantes e ON m.id_estudiante = e.id " +
                                       "JOIN usuarios u ON e.id_usuario = u.id " + "WHERE CONVERT(DATE, am.fecha) = CONVERT(DATE, '" + fechaFormatoDB + "', 120)");
        }
    }
}