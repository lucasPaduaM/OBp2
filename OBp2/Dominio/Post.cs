using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.NetWork.Dominio
{
    internal class Post : Publicacion
    {


        private static int _id { get; set; }

        public string imagen { get; set; }

        private List<Comentario> listaComentarios { get; set; }

        public bool estado { get; set; }

        public Post(string texto, DateTime fecha, Miembro autor) : base(texto, fecha, autor)
        {
            imagen = texto;
            estado = true;
            listaComentarios = new List<Comentario>();

        }
    }
}
