/**
 * @file ControladorAccion.cs
 * @brief Este archivo contiene la definición de la clase ControladorAccion que forma parte del controlador en la aplicación de gestión de acciones financieras.
 */

using punto1_primer_parcial.Modelo;
using punto1_primer_parcial.Vista;
using System;

namespace punto1_primer_parcial.Controlador
{
    /**
     * @class ControladorAccion
     * @brief Clase que se encarga de controlar las acciones financieras y gestionar la interacción entre el modelo y la vista.
     */
    public class ControladorAccion
    {
        private ModeloAccion modelo;
        private VistaAccion vista;

        /**
         * @brief Constructor de la clase ControladorAccion.
         * @param modelo El modelo de acciones financieras que se utilizará.
         * @param vista La vista de acciones financieras que se utilizará.
         * @param observador El observador de acciones financieras que se agregará al modelo.
         */
        public ControladorAccion(ModeloAccion modelo, VistaAccion vista, IObservadorAccion observador)
        {
            this.modelo = modelo;
            this.vista = vista;
            modelo.agregarObservador(observador);
        }

        /**
         * @brief Método para agregar una acción financiera al modelo y la vista.
         * @param nombre El nombre de la acción financiera.
         * @param precioActual El precio actual de la acción financiera.
         * @param precioAnterior El precio anterior de la acción financiera.
         * @param umbralSuperior El umbral superior de la acción financiera.
         * @param umbralInferior El umbral inferior de la acción financiera.
         */
        public void agregarAccion(String nombre, double precioActual, double precioAnterior, double umbralSuperior, double umbralInferior)
        {
            Accion accion = AccionFactory.crearAccion(nombre, precioActual, precioAnterior, umbralSuperior, umbralInferior);
            vista.agregarAccion(accion);
        }

        /**
         * @brief Método para eliminar una acción financiera del modelo y la vista.
         * @param nombre El nombre de la acción financiera que se va a eliminar.
         */
        public void eliminarAccion(String nombre)
        {
            foreach (Accion accion in modelo.getAcciones())
            {
                if (accion.getNombre() == nombre)
                {
                    vista.eliminarAccion(accion);
                    break;
                }
            }
        }

        /**
         * @brief Método para actualizar el precio de una acción financiera en el modelo.
         * @param nombre El nombre de la acción financiera cuyo precio se actualizará.
         * @param precio El nuevo precio de la acción financiera.
         */
        public void actualizarPrecio(String nombre, double precio)
        {
            foreach (Accion accion in modelo.getAcciones())
            {
                if (accion.getNombre() == nombre)
                {
                    modelo.actualizarPrecio(accion, precio);
                    break;
                }
            }
        }
    }
}
