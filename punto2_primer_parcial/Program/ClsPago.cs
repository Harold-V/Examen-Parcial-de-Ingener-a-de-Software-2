/**
 * @file ClsPago.cs
 * @brief Definición de la clase ClsPago.
 */

namespace punto2_primer_parcial.Program
{
    /**
     * @class ClsPago
     * @brief Clase que representa un proceso de pago y utiliza una instancia de IPago para realizarlo.
     */
    public class ClsPago
    {
        /**
         * @var _Pago
         * @brief Campo de solo lectura que almacena una instancia de IPago para el proceso de pago.
         */
        public readonly IPago _Pago;

        /**
         * @brief Constructor de ClsPago.
         * @param pago Instancia de IPago que se utilizará para el proceso de pago.
         */
        public ClsPago(IPago pago)
        {
            _Pago = pago;
        }

        /**
         * @fn void procesarPago()
         * @brief Método para procesar el pago utilizando la instancia de IPago proporcionada.
         */
        public void procesarPago()
        {
            _Pago.realizarPago();
        }
    }
}
