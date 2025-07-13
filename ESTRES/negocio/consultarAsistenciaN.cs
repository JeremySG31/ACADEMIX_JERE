using Academix.controlador;
using System.Data; 
using System;
using System.Windows.Forms; 

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
                _consultarAsistenciaControlador.ConsultarHistorialAsistenciasPorFecha(dgv, fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial de asistencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgv.DataSource = null; 
            }
        }
    }
}