using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.NetWork.Dominio
{
    internal class Sistema
    {

        private List<Usuario> _usuarios = new List<Usuario>();

        private List<Post> _posts = new List<Post>();

        private List<Invitacion> _invitaciones = new List<Invitacion>();

        public Usuario usuarioLogueado = new Usuario();

        public List<Usuario> GetUsuarios()
        {
            return _usuarios;
        }

        public List<Post> GetPosts()
        {
            return _posts;
        }

        public List<Invitacion> GetInvitaciones()
        {
            return _invitaciones;
        }

        public void AddUsuarioAdministrador(string email, string contrasenia)
        {
            Administrador administrador = new Administrador(email, contrasenia);
            _usuarios.Add(administrador);
        }

        public void AddUsuarioMiembro(string email, string contrasenia, string nombre, string apellido, DateTime fechaNac)
        {
            Miembro miembro = new Miembro(email, contrasenia, nombre, apellido, fechaNac);
            _usuarios.Add(miembro);
        }

        public bool DoLogin(string email, string password)
        {
            bool result = false;
            foreach (Usuario usuario in this._usuarios)
            {
                if (usuario.GetEmail().Equals(email))
                {
                    if (usuario.GetContrasenia().Equals(password))
                    {
                        this.usuarioLogueado = usuario;
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
