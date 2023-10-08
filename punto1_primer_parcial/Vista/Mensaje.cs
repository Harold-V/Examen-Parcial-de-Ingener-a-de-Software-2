/**
 * @file Mensaje.cs
 * @brief Este archivo contiene la definición de la clase Mensaje que se utiliza para enviar mensajes relacionados con acciones financieras.
 */

using punto1_primer_parcial.Modelo;
using System;

namespace punto1_primer_parcial.Vista
{
    /**
     * @class Mensaje
     * @brief Clase que se utiliza para enviar mensajes relacionados con acciones financieras.
     */
    public class Mensaje
    {
        /**
         * @brief Constructor de la clase Mensaje.
         * Este constructor está vacío ya que no requiere inicialización especial.
         */
        public Mensaje()
        {
        }

        /**
         * @brief Método para validar el precio de una acción y enviar un mensaje correspondiente.
         * @param accion La acción financiera cuyo precio se va a validar y notificar.
         */
        public void validarPrecioAccion(Accion accion)
        {
            if (accion.estaPorEncimaDelUmbral())
            {
                Console.WriteLine("\nLa acción " + accion.getNombre() + " está por encima del umbral superior, ya que su valor alcanzó los: " + accion.getPrecioActual() + "\n");
            }
            else if (accion.estaPorDebajoDelUmbral())
            {
                Console.WriteLine("\nLa acción " + accion.getNombre() + " está por debajo del umbral inferior, ya que su valor ha caído a los: " + accion.getPrecioActual() + "\n");
            }
        }
    }
}
