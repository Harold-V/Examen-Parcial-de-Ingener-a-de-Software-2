/**
 * @file AccionFactory.cs
 * @brief Este archivo contiene la definición de la clase AccionFactory que se utiliza para crear instancias de la clase Accion.
 */

using punto1_primer_parcial.Modelo;

namespace punto1_primer_parcial.Controlador
{
    /**
     * @class AccionFactory
     * @brief Clase que se utiliza para crear instancias de la clase Accion.
     */
    public class AccionFactory
    {
        /**
         * @brief Método estático para crear una nueva instancia de la clase Accion.
         * @param nombre El nombre de la acción financiera.
         * @param precioActual El precio actual de la acción financiera.
         * @param precioAnterior El precio anterior de la acción financiera.
         * @param umbralSuperior El umbral superior de la acción financiera.
         * @param umbralInferior El umbral inferior de la acción financiera.
         * @return Una nueva instancia de la clase Accion con los parámetros proporcionados.
         */
        public static Accion crearAccion(string nombre, double precioActual, double precioAnterior, double umbralSuperior, double umbralInferior)
        {
            return new Accion(nombre, precioActual, precioAnterior, umbralSuperior, umbralInferior);
        }
    }
}
