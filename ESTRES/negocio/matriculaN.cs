using ESTRES.controlador;
using ESTRES.modelo;
using System;
using System.Windows.Forms;

namespace ESTRES.negocio
{
    internal class matriculaN
    {
        matriculaC x;

        public matriculaN()
        {
            x = new matriculaC();
        }

        public void insertar(string id, string idEstudiante, string idGrado, DateTime fechaMatricula, string idApoderado, string idSeccion, string idTurno, string idAniolectivo, string estado)
        {
            x.insert(new matriculaM(id, idEstudiante, idGrado, fechaMatricula, idApoderado, idSeccion, idTurno, idAniolectivo, estado));
        }

        public void modificar(string id, string idEstudiante, string idGrado, DateTime fechaMatricula, string idApoderado, string idSeccion, string idTurno, string idAniolectivo, string estado)
        {
            x.update(new matriculaM(id, idEstudiante, idGrado, fechaMatricula, idApoderado, idSeccion, idTurno, idAniolectivo, estado));
        }

        public void eliminar(string id)
        {
            x.delete(new matriculaM(id, "", "", DateTime.Now, "", "", "", "", ""));
        }

        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            x.select(cb);
        }

        public void selectIDModificar(ComboBox combo)
        {
            x.selectIDModificar(combo);
        }

        public void selectIDEliminar(ComboBox combo)
        {
            x.selectIDEliminar(combo);
        }

        public void selectIDsEstudiantes(ComboBox combo)
        {
            x.selectIDsEstudiantes(combo);
        }

        public void selectIDsGrados(ComboBox combo)
        {
            x.selectIDsGrados(combo);
        }

        public void selectIDsApoderados(ComboBox combo)
        {
            x.selectIDsApoderados(combo);
        }

        public void selectIDsSecciones(ComboBox combo)
        {
            x.selectIDsSecciones(combo);
        }

        public void selectIDsTurnos(ComboBox combo)
        {
            x.selectIDsTurnos(combo);
        }

        public void selectIDsAniosLectivos(ComboBox combo)
        {
            x.selectIDsAniosLectivos(combo);
        }

        public void selectIDsEstados(ComboBox combo)
        {
            x.selectEstados(combo);
        }
    }
}