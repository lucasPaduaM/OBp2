using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.NetWork.Dominio
{
    internal class Invitacion
    {

        private static int _id { get; set; }

        public DateTime fechaSolicitud { get; set; }

        private Miembro solicitante { get; set; }

        private Miembro solicitado { get; set; }

        public bool estado { get; set; }

        public Invitacion(DateTime fechaSolicitud, Miembro solicitante, Miembro solicitado, bool estado)
        {
            this.fechaSolicitud = fechaSolicitud;
            this.solicitante = solicitante;
            this.solicitado = solicitado;
            this.estado = estado;
        }
    }
}
