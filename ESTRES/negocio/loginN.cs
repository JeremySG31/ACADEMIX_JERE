using Academix.controlador;
using Academix.modelo;

namespace Academix.negocio
{
    internal class loginN
    {
        loginC x;

        public loginN()
        {
            x = new loginC();
        }

        public loginM autenticar(string usuario, string contrasenia)
        {
            if (usuario.Trim() == "" || contrasenia.Trim() == "")
            {
                return null;
            }

            loginM datos = x.seleccionar(usuario, contrasenia);

            if (datos != null && datos.Estado.ToLower() == "activo")
            {
                return datos;
            }

            return null;
        }
    }
}
