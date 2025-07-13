using ESTRES.dao; // Asegúrate de que esta referencia sea correcta para tu clase de conexión
using System.Data;
using System;

namespace Academix.controlador
{
    internal class ConsultarAsistenciaC
    {
        private conexion x;

        public ConsultarAsistenciaC()
        {
            x = new conexion();
        }

        public DataTable ConsultarHistorialAsistenciasPorFecha(DateTime fecha)
        {
            string fechaFormatoDB = fecha.ToString("yyyy-MM-dd");
            // Nota: Se usará un JOIN para obtener el nombre del estudiante,
            // ya que mostrar solo el ID de matrícula no es muy amigable.
            // Si estrictamente quieres solo id_matricula, fecha, estado, puedes simplificar la query.
            // Pero es muy común querer el nombre. Si no, quita las tablas 'estudiantes' y 'usuarios' y el JOIN.
            return x.manipular("SELECT " +
                               "m.id AS id_matricula, " +
                               "u.nombres + ' ' + u.nombres + ' ' + u.ape_paterno + ' ' + u.ape_materno AS nombre_completo_estudiante, " +
                               "am.fecha AS fecha_asistencia, " +
                               "am.estado AS estado_asistencia " +
                               "FROM asistencias_matriculados am " +
                               "JOIN matriculas m ON am.id_matricula = m.id " +
                               "JOIN estudiantes e ON m.id_estudiante = e.id " +
                               "JOIN usuarios u ON e.id_usuario = u.id " +
                               "WHERE CONVERT(DATE, am.fecha) = CONVERT(DATE, '" + fechaFormatoDB + "', 120)");
        }
    }
}