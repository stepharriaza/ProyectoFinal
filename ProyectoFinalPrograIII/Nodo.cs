using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPrograIII
{
    public class Nodo
    {
        private Cliente inf;
        private Nodo siguiente;
        private Nodo anterior;

        public Nodo (Cliente inf)
        {

            this.inf = inf;
            this.siguiente = null;
            this.anterior = null;

        }



        public Nodo Sig
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo Atras
        {

            get { return anterior; }
            set { anterior = value; }

        }

        public Cliente getCliente() { return this.inf; }
        public void setCliente(Cliente value) { this.inf = value; }

    }
}
