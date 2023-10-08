/**
 * @file ObservadorAccionTexto.cs
 * @brief Este archivo contiene la definición de la clase ObservadorAccionTexto que implementa la interfaz IObservadorAccion para observar acciones financieras y enviar mensajes de texto.
 */

using punto1_primer_parcial.Modelo;

namespace punto1_primer_parcial.Vista
{
    /**
     * @class ObservadorAccionTexto
     * @brief Clase que implementa la interfaz IObservadorAccion para observar acciones financieras y enviar mensajes de texto en respuesta a cambios.
     */
    public class ObservadorAccionTexto : IObservadorAccion
    {
        /**
         * @brief Método para actualizar el observador en respuesta a cambios en una acción financiera.
         * @param accion La acción financiera que ha experimentado cambios.
         */
        public void actualizar(Accion accion)
        {
            // Crear una instancia de la clase Mensaje para enviar mensajes.
            Mensaje mensaje = new Mensaje();

            // Validar y enviar mensajes relacionados con la acción financiera.
            mensaje.validarPrecioAccion(accion);
        }
    }
}
