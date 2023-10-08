/**
 * @file IAutenticar.cs
 * @brief Definición de la interfaz IAutenticar.
 */

namespace punto2_primer_parcial.Program
{
    /**
     * @interface IAutenticar
     * @brief Define el contrato para la autenticación.
     */
    public interface IAutenticar
    {
        /**
         * @fn bool Autenticar()
         * @brief Realiza la autenticación.
         * @return true si la autenticación es exitosa, false en caso contrario.
         */
        bool Autenticar();
    }
}
