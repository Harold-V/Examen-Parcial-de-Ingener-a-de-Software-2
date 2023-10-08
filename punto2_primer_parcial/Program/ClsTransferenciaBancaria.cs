/**
 * @file ClsTransferenciaBancaria.cs
 * @brief Definición de la clase ClsTransferenciaBancaria.
 */

using System;

namespace punto2_primer_parcial.Program
{
    /**
     * @class ClsTransferenciaBancaria
     * @brief Clase que representa una transferencia bancaria y cumple con las interfaces ILlenarInfo y IPago.
     */
    public class ClsTransferenciaBancaria : ILlenarInfo, IPago
    {
        private int numCuenta;
        private string password;

        /**
         * @brief Constructor por defecto de ClsTransferenciaBancaria.
         */
        public ClsTransferenciaBancaria()
        {
        }

        /**
         * @brief Constructor parametrizado de ClsTransferenciaBancaria.
         * @param numCuenta Número de cuenta bancaria.
         * @param password Contraseña asociada a la cuenta bancaria.
         */
        public ClsTransferenciaBancaria(int numCuenta, string password)
        {
            NumCuenta = numCuenta;
            Password = password;
        }

        /**
         * @property NumCuenta
         * @brief Propiedad para obtener o establecer el número de cuenta bancaria.
         */
        public int NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }

        /**
         * @property Password
         * @brief Propiedad para obtener o establecer la contraseña de la cuenta bancaria.
         */
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /**
         * @fn void llenarInfo()
         * @brief Método para llenar información de la cuenta bancaria.
         */
        public void llenarInfo()
        {
            // Se llena la información de la cuenta bancaria
        }

        /**
         * @fn bool realizarPago()
         * @brief Método para realizar un pago con transferencia bancaria.
         * @return true si el pago se realizó con éxito, false en caso contrario.
         */
        public bool realizarPago()
        {
            // Se realiza el pago
            Console.WriteLine("Se realizó un pago con Transferencia Bancaria");
            // Retorna true si se hizo el pago; de lo contrario, retorna false
            return true;
        }
    }
}
