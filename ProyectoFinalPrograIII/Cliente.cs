using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPrograIII
{
    public class Cliente
    {
        private String name;
        private String correo;
        private String telefono;
        private Habitaciones[] habitaciones = new Habitaciones[3];
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public void setCorreo(String correo)
        {
            this.correo = correo;
        }
        public String getCorreo()
        {
            return this.correo;
        }
        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }
        public String getTelefono()
        {
            return this.telefono;
        }
        public Habitaciones[] getHabitaciones()
        {
            return this.habitaciones;
        }

        public void setHabitaciones(Habitaciones[] habitaciones)
        {
            this.habitaciones = habitaciones;
        }
    }
}
