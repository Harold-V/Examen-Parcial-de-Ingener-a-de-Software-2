/**
 * @file Program.cs
 * @brief Este archivo contiene la definición de la clase Program que contiene el método de entrada principal Main.
 */

using System;

namespace punto2_primer_parcial.Program
{
    /**
     * @class Program
     * @brief Clase que contiene el método de entrada principal Main.
     */
    internal class Program
    {
        /**
         * @fn public static void Main()
         *
         * @brief Método de entrada principal del programa.
         *
         * Este método crea una instancia de la clase ClsPago con una instancia de cualquier metodo de pago,
         * y luego llama al método procesarPago de la instancia de ClsPago. Finalmente, espera a que el usuario
         * presione una tecla antes de terminar.
         */
        public static void Main()
        {
            ClsPago pago = new ClsPago(new ClsTargetaCredito());
            pago.procesarPago();
            Console.ReadKey();
        }

    }
}
