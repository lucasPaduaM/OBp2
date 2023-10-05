using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.NetWork.Dominio
{
    internal class Administrador : Usuario
    {
        public void BloquearMiembro(Miembro unMiembro)
        {

        }

        public Administrador(string email, string contrasenia)
        {
            SetEmail(email);
            SetContrasenia(contrasenia);
        }
    }

}
