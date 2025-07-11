using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academix.modelo
{
    internal class rolesM
    {
        public rolesM(string id, string nombreRol)
        {
            Id = id;
            this.NombreRol = nombreRol;
        }

        public string Id { get; set; }
        public string NombreRol{ get; set; }



    }
}