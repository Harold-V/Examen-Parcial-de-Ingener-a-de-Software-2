/**
 * @file IObservadorAccion.cs
 * @brief Este archivo contiene la definición de la interfaz IObservadorAccion utilizada para observar cambios en acciones financieras.
 */

namespace punto1_primer_parcial.Modelo
{
    /**
     * @interface IObservadorAccion
     * @brief Interfaz que define el contrato para observar cambios en acciones financieras.
     */
    public interface IObservadorAccion
    {
        /**
         * @brief Método para actualizar el observador en respuesta a cambios en una acción financiera.
         * @param accion La acción financiera que ha experimentado cambios.
         */
        void actualizar(Accion accion);
    }
}
