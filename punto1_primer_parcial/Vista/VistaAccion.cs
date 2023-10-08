/**
 * @file Vista de la Acccion
 * @brief Este archivo contiene la definición de la clase VistaAccion que forma parte de la vista en la aplicación de gestión de acciones financieras.
 */

using punto1_primer_parcial.Modelo;

namespace punto1_primer_parcial.Vista
{
    /**
     * @class VistaAccion
     * @brief Clase que se encarga de la representación y visualización de las acciones financieras en la aplicación.
     */
    public class VistaAccion
    {
        private ModeloAccion modelo;

        /**
         * @brief Constructor de la clase VistaAccion.
         * @param modelo El modelo de acciones que se utilizará para obtener datos.
         */
        public VistaAccion(ModeloAccion modelo)
        {
            this.modelo = modelo;
        }

        /**
         * @brief Método para agregar una acción al modelo.
         * @param accion La acción que se va a agregar al modelo.
         */
        public void agregarAccion(Accion accion)
        {
            modelo.agregarAccion(accion);
        }

        /**
         * @brief Método para eliminar una acción del modelo.
         * @param accion La acción que se va a eliminar del modelo.
         */
        public void eliminarAccion(Accion accion)
        {
            modelo.eliminarAccion(accion);
        }

        /**
         * @brief Método para mostrar la lista de acciones con detalles en la consola.
         */
        public void mostrarAcciones()
        {
            System.Console.WriteLine("Acciones:");

            // Iterar a través de las acciones en el modelo y mostrar los detalles de cada una.
            foreach (Accion accion in modelo.getAcciones())
            {
                System.Console.WriteLine("\n - Nombre: " + accion.getNombre());
                System.Console.WriteLine(" - Precio actual: " + accion.getPrecioActual());
                System.Console.WriteLine(" - Precio Anterior: " + accion.getPrecioAnterior());
                System.Console.WriteLine(" - Umbral Superior: " + accion.getUmbralSuperior());
                System.Console.WriteLine(" - Umbral Inferior: " + accion.getUmbralInferior() + "\n");
            }
        }
    }
}
