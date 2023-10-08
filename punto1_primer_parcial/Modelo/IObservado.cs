/**
 * @file IObservado.cs
 * @brief Este archivo contiene la definición de la interfaz IObservado utilizada para gestionar observadores de acciones financieras.
 */

namespace punto1_primer_parcial.Modelo
{
    /**
     * @interface IObservado
     * @brief Interfaz que define el contrato para gestionar observadores de acciones financieras.
     */
    public interface IObservado
    {
        /**
         * @brief Método para agregar un observador a la lista de observadores.
         * @param observador El observador de acciones financieras que se va a agregar.
         */
        void agregarObservador(IObservadorAccion observador);

        /**
         * @brief Método para eliminar un observador de la lista de observadores.
         * @param observador El observador de acciones financieras que se va a eliminar.
         */
        void eliminarObservador(IObservadorAccion observador);

        /**
         * @brief Método para notificar a todos los observadores sobre un cambio en una acción financiera.
         * @param accion La acción financiera que ha experimentado cambios y que se notificará a los observadores.
         */
        void notificarObservadores(Accion accion);
    }
}
