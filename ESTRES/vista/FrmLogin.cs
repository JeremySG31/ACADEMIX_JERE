using Academix.modelo;
using Academix.negocio;
using ESTRES;
using ESTRES.vista;
using System;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            campo_contrasenia.UseSystemPasswordChar = true;
            checkBoxMostrar.CheckedChanged += checkBoxMostrar_CheckedChanged;
            this.AcceptButton = login;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            campo_usuario.Text = "";
            campo_contrasenia.Text = "";
            campo_usuario.Focus();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string usuario = campo_usuario.Text.Trim();
            string contrasenia = campo_contrasenia.Text;

            if (usuario == "" || contrasenia == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            loginN x = new loginN();
            loginM datos = x.autenticar(usuario, contrasenia);

            if (datos == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos o el usuario está inactivo.");
                return;
            }

            this.Hide();
            Form siguiente = null;

            switch (datos.Rol.ToLower())
            {
                case "profesor":
                    siguiente = new FrmPanelProfesor(); break;
                case "estudiante":
                    siguiente = new FrmPanelEstudiante(); break;
                case "apoderado":
                    siguiente = new FrmPanelApoderado(); break;
                case "administrador":
                    siguiente = new FrmPanelAdministrador(); break;
                default:
                    MessageBox.Show("Rol no reconocido");
                    this.Show();
                    return;
            }

            siguiente.ShowDialog();
            this.Show();
            campo_usuario.Text = "";
            campo_contrasenia.Text = "";
            campo_usuario.Focus();
        }

        private void campo_usuario_TextChanged(object sender, EventArgs e) { }

        private void campo_contrasenia_TextChanged(object sender, EventArgs e) { }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            campo_contrasenia.UseSystemPasswordChar = !checkBoxMostrar.Checked;
        }
    }
}
