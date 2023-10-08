/**
 * @file Accion.cs
 * @brief Este archivo contiene la definición de la clase Accion que representa una acción financiera.
 */

namespace punto1_primer_parcial.Modelo
{
    /**
     * @class Accion
     * @brief Clase que representa una acción financiera y sus propiedades.
     */
    public class Accion
    {
        private string nombre;
        private double precioActual;
        private double precioAnterior;
        private double umbralSuperior;
        private double umbralInferior;

        public Accion(string nombre, double precioActual, double precioAnterior, double umbralSuperior, double umbralInferior)
        {
            this.nombre = nombre;
            this.precioActual = precioActual;
            this.precioAnterior = precioAnterior;
            this.umbralSuperior = umbralSuperior;
            this.umbralInferior = umbralInferior;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public double getPrecioActual()
        {
            return precioActual;
        }

        public void setPrecioActual(double precioActual)
        {
            this.precioActual = precioActual;
        }

        public double getPrecioAnterior()
        {
            return precioAnterior;
        }

        public void setPrecioAnterior(double precioAnterior)
        {
            this.precioAnterior = precioAnterior;
        }

        public double getUmbralSuperior()
        {
            return umbralSuperior;
        }

        public void setUmbralSuperior(double umbralSuperior)
        {
            this.umbralSuperior = umbralSuperior;
        }

        public double getUmbralInferior()
        {
            return umbralInferior;
        }

        public void setUmbralInferior(double umbralInferior)
        {
            this.umbralInferior = umbralInferior;
        }

        /**
         * @brief Método para verificar si la acción financiera está por encima del umbral superior.
         * @return true si la acción está por encima del umbral superior, false de lo contrario.
         */
        public bool estaPorEncimaDelUmbral()
        {
            return precioActual > umbralSuperior;
        }

        /**
         * @brief Método para verificar si la acción financiera está por debajo del umbral inferior.
         * @return 'true' si la acción está por debajo del umbral inferior, 'false de lo contrario.
         */
        public bool estaPorDebajoDelUmbral()
        {
            return precioActual < umbralInferior;
        }
    }
}
