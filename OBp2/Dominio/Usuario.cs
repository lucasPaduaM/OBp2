using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.NetWork.Dominio
{
    internal class Usuario
    {

        private string _email { get; set; }
        private string _contrasenia { get; set; }

        public string GetEmail()
        {
            return _email;
        }

        public string GetContrasenia()
        {
            return _contrasenia;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }
        public void SetContrasenia(string contrasenia)
        {
            _contrasenia = contrasenia;
        }
    }
}