/**
 * @file IPago.cs
 * @brief Definición de la interfaz IPago.
 */

namespace punto2_primer_parcial.Program
{
    /**
     * @interface IPago
     * @brief Define el contrato para realizar un pago.
     */
    public interface IPago
    {
        /**
         * @fn bool realizarPago()
         * @brief Realiza un pago.
         * @return true si el pago se realizó con éxito, false en caso contrario.
         */
        bool realizarPago();
    }
}
