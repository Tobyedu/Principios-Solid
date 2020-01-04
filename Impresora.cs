using System;
namespace CarritoDeCompras
{
    public class Impresora
    {
        //principio de reponsabilidad unica
        public Impresora()
        {
        }

        public void ImprimirDatosCliente(Cliente cliente)
        {
            //imprime las propiedades dentro de mi clase cliente
            Console.WriteLine("Nombre\t\t\tApellido\t\t\tN°Cedula\t\t\tEmail");
            Console.WriteLine(cliente.Nombres +"\t\t"+ cliente.Apellidos + "\t\t"+cliente.Cedula +"\t\t" + cliente.Email);


            //return cliente.Nombres + " " + cliente.Apellidos;

        }

    } 
    }

