using Academix.modelo;
using ESTRES.dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class estudianteApoderadoC
    {
        conexion x;
        public estudianteApoderadoC()
        {
            x = new conexion();
        }
        public void insert(estudianteApoderadoM dato)
        {
            x.manipular(
                "INSERT INTO estudiante_apoderados (id, id_apoderado, id_estudiante, parentesco, prioridad, estado) " +
                "VALUES ('" + dato.Id + "', '" + dato.IdApoderado + "', '" + dato.IdEstudiante + "', '" + dato.Parentesco + "', '" + dato.Prioridad + "', '" + dato.Estado + "')"
            );
        }
        public void update(estudianteApoderadoM dato)
        {
            x.manipular(
                "UPDATE estudiante_apoderados SET " +
                "id_apoderado = '" + dato.IdApoderado + "', " +
                "id_estudiante = '" + dato.IdEstudiante + "', " +
                "parentesco = '" + dato.Parentesco + "', " +
                "prioridad = '" + dato.Prioridad + "', " +
                "estado = '" + dato.Estado + "' " +
                "WHERE id = '" + dato.Id + "'"
            );
        }
        public void delete(estudianteApoderadoM dato)
        {
            x.manipular(
                "DELETE FROM estudiante_apoderados WHERE id = '" + dato.Id + "'"
            );
        }


        public void select(ComboBox cbBuscarColumna)
        {
            cbBuscarColumna.DataSource = x.manipular("SELECT id, id_estudiante,parentesco  FROM estudiante_apoderados");
            cbBuscarColumna.DisplayMember = "id";
            cbBuscarColumna.ValueMember = "id_estudiante";
            cbBuscarColumna.SelectedIndex = 0;
        }

        public void selectIDestudiante(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT DISTINCT id_estudiante FROM estudiante_apoderados");
            combo.DataSource = dt;
            combo.DisplayMember = "id_estudiante";
            combo.ValueMember = "id_estudiante";
            combo.SelectedIndex = -1;
        }

        public void selectIDapoderado(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT DISTINCT id_apoderado FROM estudiante_apoderados");
            combo.DataSource = dt;
            combo.DisplayMember = "id_apoderado";
            combo.ValueMember = "id_apoderado";
            combo.SelectedIndex = -1;
        }

        public void selectPrioridad(ComboBox combo)
        {
            var prioridades = new[]
            {
        new { Valor = 1, Texto = "1 - Muy baja" },
        new { Valor = 2, Texto = "2 - Baja" },
        new { Valor = 3, Texto = "3 - Media" },
        new { Valor = 4, Texto = "4 - Alta" },
        new { Valor = 5, Texto = "5 - Muy alta" }
    };
            combo.DataSource = prioridades;
            combo.DisplayMember = "Texto";
            combo.ValueMember = "Valor";
            combo.SelectedIndex = -1;
        }

        public void selectEstado(ComboBox combo)
        {
            var estados = new[]
            {
        new { Valor = "Activo", Texto = "Activo" },
        new { Valor = "Inactivo", Texto = "Inactivo" }
    };
            combo.DataSource = estados;
            combo.DisplayMember = "Texto";
            combo.ValueMember = "Valor";
            combo.SelectedIndex = -1;
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM estudiante_apoderados");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, id_apoderado, id_estudiante, parentesco, prioridad, estado FROM estudiante_apoderados");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("select * from estudiante_apoderados");

        }
    }
}