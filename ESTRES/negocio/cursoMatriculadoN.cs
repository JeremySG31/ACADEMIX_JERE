﻿using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class cursoMatriculadoN
    {
        cursoMatriculadoC x;
        public cursoMatriculadoN()
        {
            x = new cursoMatriculadoC();
        }

        public void insertar(string id, string id_matricula, string id_cursos, string id_estudiante)
        {
            x.insert(new cursoMatriculadoM(id, id_estudiante, id_cursos, id_matricula));
        }

        public void modificar(string id, string id_matricula, string id_cursos, string id_estudiante)
        {
            x.update(new cursoMatriculadoM(id, id_estudiante, id_cursos, id_matricula));
        }

        public void eliminar(string id)
        {
            x.delete(id);
        }

        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}