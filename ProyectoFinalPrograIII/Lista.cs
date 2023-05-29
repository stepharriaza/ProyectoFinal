using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalPrograIII
{
    public class Lista
    {
        private String name;
        private Nodo cabeza;
        private Nodo cola;

        public Lista(string name)
        {
            this.name = name;
            this.cabeza = null;
            this.cola = null;
        }

        public String getName()
        {
            return this.name;
        }

        
        public Nodo getCola()
        {
            return this.cola;
        }

        public void setName(String name) { this.name = name; }

        public void setCabeza(Nodo cabeza) { this.cabeza = cabeza; }


        public void setCola(Nodo cola) { this.cabeza = cola; }

        public bool IsListEmpty()
        {
            return this.cabeza == null;
        }

        public void Insertar(Nodo nuevo)
        {
            //Nodo nuevo = new Nodo();
            //nuevo 
            if (IsListEmpty())
            {
                cabeza = nuevo;
                cola = nuevo;
                cabeza.Sig = cabeza;
                cabeza.Atras = cola;
            }
            else
            {
                cola.Sig = nuevo;
                nuevo.Atras = cola;
                nuevo.Sig = cabeza;
                cola = nuevo;
                cabeza.Atras = cola;
            }
            Console.WriteLine("\n Nuevo nodo ingresado con exito");

        }

        public string mostrarLista()
        {
            String message = "";

            Nodo actual = this.cabeza;

            do
            {
                Cliente cliente = actual.getCliente();

                message += "Nombre cliente:\t" + cliente.getName() +"\nCorreo electronico:\t"+ cliente.getCorreo() + " \nNumero de telefono:\t"+ cliente.getTelefono() + "\n\n";
                actual = actual.Sig;

            } while (actual != null && actual != cabeza);
            return message;
        }

        public bool Buscar(String buscarNombre)
        {
            bool exists = false;

            Nodo actual = this.cabeza;

            do
            {
                Cliente cliente = actual.getCliente();
                if (cliente.getName() == buscarNombre)
                {
                    exists= true;
                    break;
                }

                actual = actual.Sig;
            } while (actual != null && actual != cabeza);

            return exists;
        }

        //public void eliminar()
        //{
        //    Nodo actual = new Nodo();
        //    actual = cabeza;
        //    Nodo anterior = new Nodo();
        //    anterior = null;
        //    bool encontrado = false;
        //    Console.WriteLine("Ingrese el dato del nodo a buscar: ");
        //    int buscar = Int32.Parse(Console.ReadLine());
        //    if (actual!= null)
        //    {
        //        do
        //        {
        //            if (actual.Dato == buscar)
        //            {
        //                if (actual == cabeza)
        //                {
        //                    cabeza = cabeza.Sig;
        //                    cabeza.Atras = cola;
        //                    cola.Sig = cabeza;
        //                }
        //                else if (actual==cola)
        //                {
        //                    cola = anterior;
        //                    anterior.Sig = cabeza;
        //                    cabeza.Atras = cola;
        //                }
        //                else
        //                {
        //                    anterior.Sig = actual.Sig;
        //                    actual.Sig.Atras = anterior;
        //                }
        //                Console.WriteLine("\n Nodo eliminado con exito\n");
        //                encontrado = true;
        //            }
        //            anterior = actual;
        //            actual = actual.Sig;
        //        } while (actual != cabeza && encontrado != true);
        //        if (!encontrado)
        //        {
        //            Console.WriteLine("\n No encontrado");
        //        }
        //    }
        //    else
        //    {

        //        Console.WriteLine("\n La lista se encuentra vacía");
        //    }
        //}

        //public void insertarPosicion2()
        //{

        //    Nodo actual = new Nodo();
        //    actual = cabeza;
        //    Nodo nuevo = new Nodo();
        //    Nodo anterior = new Nodo();
        //    anterior = null;
        //    Console.WriteLine("Ingrese posicion ");
        //    int posicion = Int32.Parse(Console.ReadLine());

        //    if (posicion == 0)
        //    {
        //        nuevo.Sig = cabeza;
        //        cabeza = nuevo;
        //        nuevo.Atras = cola;
        //        cola.Sig = cabeza;
        //    }
        //    else
        //    {
        //        //anterior = actual;
        //        for (int i = 0; i <= posicion-1; i++)
        //        {
        //            anterior = actual;
        //            actual = actual.Sig;
        //            if (anterior == cola)
        //            {
        //                Console.WriteLine("Posición fuera de rango, la nueva posición será {0}", (i+1));
        //                break;
        //            }
        //        }

        //        Console.WriteLine("Ingrese el dato ");
        //        nuevo.Dato = Int32.Parse(Console.ReadLine());

        //        nuevo.Atras = anterior;
        //        anterior.Sig = nuevo;
        //        nuevo.Sig = actual;
        //        actual.Atras = nuevo;

        //    }



        //}


    }
}
