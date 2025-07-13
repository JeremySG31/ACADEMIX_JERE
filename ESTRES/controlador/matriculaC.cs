using ESTRES.dao;
using ESTRES.modelo;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.controlador
{
    internal class matriculaC
    {
        conexion x;

        public matriculaC()
        {
            x = new conexion();
        }

        public void insert(matriculaM dato)
        {
            x.manipular("INSERT INTO matriculas (id, id_estudiante, id_grado, fecha_matricula, id_apoderado, id_seccion, id_turno, id_aniolectivo, estado) VALUES ('" + dato.Id + "','" + dato.IdEstudiante + "','" + dato.IdGrado + "','" + dato.FechaMatricula.ToString("yyyy-MM-dd") + "','" + dato.IdApoderado + "','" + dato.IdSeccion + "','" + dato.IdTurno + "','" + dato.IdAniolectivo + "','" + dato.Estado + "')");
        }

        public void update(matriculaM dato)
        {
            x.manipular("UPDATE matriculas SET id_estudiante='" + dato.IdEstudiante + "', id_grado='" + dato.IdGrado + "', fecha_matricula='" + dato.FechaMatricula.ToString("yyyy-MM-dd") + "', id_apoderado='" + dato.IdApoderado + "', id_seccion='" + dato.IdSeccion + "', id_turno='" + dato.IdTurno + "', id_aniolectivo='" + dato.IdAniolectivo + "', estado='" + dato.Estado + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(matriculaM dato)
        {
            x.manipular("DELETE FROM matriculas WHERE id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id, id_estudiante, fecha_matricula FROM matriculas");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "id_estudiante"; 
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = -1;
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT * FROM matriculas");
            L.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, id_estudiante, id_grado, fecha_matricula, id_apoderado, id_seccion, id_turno, id_aniolectivo, estado FROM matriculas");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM matriculas");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDsEstudiantes(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM estudiantes");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDsGrados(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM grados"); 
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDsApoderados(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM apoderados"); 
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDsSecciones(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM secciones"); 
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDsTurnos(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM turnos"); 
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDsAniosLectivos(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM aniosLectivos"); 
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectEstados(ComboBox combo)
        {

            DataTable dt = x.manipular("SELECT DISTINCT estado FROM matriculas"); 
            combo.DataSource = dt;
            combo.DisplayMember = "estado"; 
            combo.ValueMember = "estado";
            combo.SelectedIndex = -1;
        }
    }
}