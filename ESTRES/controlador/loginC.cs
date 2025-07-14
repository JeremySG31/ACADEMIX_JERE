using ESTRES.dao;
using Academix.modelo;
using System;
using System.Data;

namespace Academix.controlador
{
    internal class loginC
    {
        conexion x;

        public loginC()
        {
            x = new conexion();
        }

        public loginM seleccionar(string usuario, string contrasenia)
        {
            string consulta = "SELECT u.nombre_usuario, u.contrasena, u.estado, r.nombre_rol AS rol " +
                              "FROM usuarios u " +
                              "INNER JOIN roles r ON u.rol = r.id " +
                              "WHERE u.nombre_usuario = '" + usuario + "' AND u.contrasena = '" + contrasenia + "'";

            DataTable dt = x.manipular(consulta);

            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                return new loginM(
                    row["nombre_usuario"].ToString(),
                    row["contrasena"].ToString(),
                    row["estado"].ToString(),
                    row["rol"].ToString()
                );
            }

            return null;
        }
    }
}
