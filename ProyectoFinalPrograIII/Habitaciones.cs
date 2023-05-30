using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPrograIII
{
    public class Habitaciones
    {
        private String habitacion;
        private int cantidad;
        private String fechaEntrada;
        private String fechaSalida;

        public Habitaciones(string habitacion, int cantidad, string fechaEntrada, string fechaSalida)
        {
            this.habitacion=habitacion;
            this.cantidad=cantidad;
            this.fechaEntrada=fechaEntrada;
            this.fechaSalida=fechaSalida;
        }

        //private String tipoHabitacion;



        public void setHabitacion(String habitacion)
        {
            this.habitacion = habitacion;
        }
        public String getHabitacion()
        {
            return this.habitacion;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }
        public void setEntrada(String fechaEntrada)
        {
            this.fechaEntrada = fechaEntrada;
        }
        public String getEntrada()
        {
            return this.fechaEntrada;
        }
        public void setSalida(String fechaSalida)
        {
            this.fechaSalida = fechaSalida;
        }
        public String getSalida()
        {
            return this.fechaSalida;
        }
    }
}
