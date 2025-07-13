using System.Windows.Forms;
using System;
using System.Data;
using Academix.negocio;

namespace Academix.vista
{
    public partial class FrmConsultarHistorialA : Form
    {
        private ConsultarAsistenciaN _consultarAsistenciaNegocio;

        public FrmConsultarHistorialA()
        {
            InitializeComponent(); 
            _consultarAsistenciaNegocio = new ConsultarAsistenciaN();
            ConfigurarDGVHistorial();
        }

        private void ConfigurarDGVHistorial()
        {
            dgvHistorial.Columns.Clear();
            dgvHistorial.AutoGenerateColumns = false;

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "id_matricula",
                HeaderText = "ID Matrícula",
                DataPropertyName = "id_matricula",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nombre_completo_estudiante",
                HeaderText = "Nombre Estudiante",
                DataPropertyName = "nombre_completo_estudiante",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "fecha_asistencia",
                HeaderText = "Fecha Asistencia",
                DataPropertyName = "fecha_asistencia",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "estado_asistencia",
                HeaderText = "Estado",
                DataPropertyName = "estado_asistencia",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void btnConsultarAsistencias_Click(object sender, System.EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFechaHistorial.Value.Date;
            _consultarAsistenciaNegocio.CargarHistorialAsistenciasEnDGV(dgvHistorial, fechaSeleccionada);
        }

    }
}