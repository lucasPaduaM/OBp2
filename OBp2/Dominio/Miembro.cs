using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.NetWork.Dominio
{
    internal class Miembro : Usuario
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public DateTime fechaNac { get; set; }

        public bool bloqueado { get; set; }

        private List<Miembro> listaAmigos;

        public Miembro(string email, string contrasenia, string nombre, string apellido, DateTime fechaNac)
        {
            SetEmail(email);
            SetContrasenia(contrasenia);
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            bloqueado = false;
            listaAmigos = new List<Miembro>();
        }
    }
}
