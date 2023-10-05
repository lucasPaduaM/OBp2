using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.NetWork.Dominio
{
    internal class Publicacion
    {

        private static int _id { get; set; }

        private string texto { get; set; }

        private DateTime fecha { get; set; }

        private Miembro autor { get; set; }

        public Publicacion(string texto, DateTime fecha, Miembro autor)
        {
            this.texto = texto;
            this.fecha = fecha;
            this.autor = autor;
        }

        public void CalcularValorDeAceptacion() //no es un void, es solamente momentaneo para que
                                                //no de error
        {

        }
    }
}
