using Academix.controlador; // Asegúrate de que esta referencia sea correcta
using System.Data;
using System;
using System.Windows.Forms; // Necesario para DataGridView

namespace Academix.negocio
{
    internal class ConsultarAsistenciaN
    {
        private ConsultarAsistenciaC _consultarAsistenciaControlador;

        public ConsultarAsistenciaN()
        {
            _consultarAsistenciaControlador = new ConsultarAsistenciaC();
        }

        public void CargarHistorialAsistenciasEnDGV(DataGridView dgv, DateTime fecha)
        {
            try
            {
                DataTable dt = _consultarAsistenciaControlador.ConsultarHistorialAsistenciasPorFecha(fecha);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial de asistencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgv.DataSource = null; // Limpiar el DGV en caso de error
            }
        }
    }
}