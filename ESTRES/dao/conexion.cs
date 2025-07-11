using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ESTRES.dao
{
    internal class conexion
    {
        SqlConnection cnSql;    //Conectar BD
        SqlCommand coSql;       //Manipulacion
        SqlDataAdapter daSql;   //Consultas
        DataTable dtTabla;      //Tabla
        public conexion()
        {
            try
            {
                //cnSql = new SqlConnection("Data Source=176.50.40.250;" + "Initial Catalog=G1asistenciaEC;User ID=sa;" + "password=12345");
                cnSql = new SqlConnection("Data Source=192.168.18.157;" + "Initial Catalog=G1asistenciaEC;Integrated Security=True;");

                cnSql.Open();
                // MessageBox.Show("Exito", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable manipular(string cadConsul)
        {
            try
            {
                coSql = new SqlCommand(cadConsul, cnSql);
                daSql = new SqlDataAdapter(coSql);
                dtTabla = new DataTable();
                daSql.Fill(dtTabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtTabla;
        }
    }
}
