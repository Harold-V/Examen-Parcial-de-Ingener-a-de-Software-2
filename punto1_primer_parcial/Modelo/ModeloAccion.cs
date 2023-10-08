/**
 * @file Modelo de la Accion
 * @brief Este archivo contiene la definición de la clase ModeloAccion que forma parte del modelo en la aplicación de gestión de acciones financieras.
 */

using System.Collections.Generic;

namespace punto1_primer_parcial.Modelo
{
    /**
     * @class ModeloAccion
     * @brief Clase que representa el modelo de la aplicación de gestión de acciones financieras.
     * Implementa la interfaz IObservado para observar cambios en las acciones.
     */
    public class ModeloAccion : IObservado
    {
        private List<Accion> acciones;
        private List<IObservadorAccion> observadores;

        /**
         * @brief Constructor de la clase ModeloAccion.
         * Inicializa las listas de acciones y observadores.
         */
        public ModeloAccion()
        {
            acciones = new List<Accion>();
            observadores = new List<IObservadorAccion>();
        }

        /**
         * @brief Método para obtener la lista de acciones en el modelo.
         * @return Lista de acciones en el modelo.
         */
        public List<Accion> getAcciones()
        {
            return acciones;
        }

        /**
         * @brief Método para obtener la lista de observadores del modelo.
         * @return Lista de observadores del modelo.
         */
        public List<IObservadorAccion> getObservadores()
        {
            return observadores;
        }

        /**
         * @brief Método para agregar una acción al modelo.
         * @param accion La acción que se va a agregar al modelo.
         */
        public void agregarAccion(Accion accion)
        {
            acciones.Add(accion);
        }

        /**
         * @brief Método para eliminar una acción del modelo.
         * @param accion La acción que se va a eliminar del modelo.
         */
        public void eliminarAccion(Accion accion)
        {
            acciones.Remove(accion);
        }

        /**
         * @brief Método para actualizar el precio de una acción en el modelo.
         * @param accion La acción cuyo precio se actualizará.
         * @param precio El nuevo precio de la acción.
         */
        public void actualizarPrecio(Accion accion, double precio)
        {
            accion.setPrecioAnterior(accion.getPrecioActual());
            accion.setPrecioActual(precio);
            notificarObservadores(accion);
        }

        /**
         * @brief Método para agregar un observador al modelo.
         * @param observador El observador que se va a agregar al modelo.
         */
        public void agregarObservador(IObservadorAccion observador)
        {
            observadores.Add(observador);
        }

        /**
         * @brief Método para eliminar un observador del modelo.
         * @param observador El observador que se va a eliminar del modelo.
         */
        public void eliminarObservador(IObservadorAccion observador)
        {
            observadores.Remove(observador);
        }

        /**
         * @brief Método para notificar a todos los observadores sobre un cambio en una acción.
         * @param accion La acción que ha experimentado cambios.
         */
        public void notificarObservadores(Accion accion)
        {
            foreach (IObservadorAccion observador in observadores)
            {
                observador.actualizar(accion);
            }
        }
    }
}
