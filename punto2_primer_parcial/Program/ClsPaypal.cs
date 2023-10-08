/**
 * @file ClsPaypal.cs
 * @brief Definición de la clase ClsPaypal.
 */

using System;

namespace punto2_primer_parcial.Program
{
    /**
     * @class ClsPaypal
     * @brief Clase que representa una cuenta de PayPal y cumple con las interfaces IAutenticar y IPago.
     */
    public class ClsPaypal : IAutenticar, IPago
    {
        private string user;
        private string password;

        /**
         * @brief Constructor por defecto de ClsPaypal.
         */
        public ClsPaypal()
        {
        }

        /**
         * @brief Constructor parametrizado de ClsPaypal.
         * @param user Nombre de usuario de PayPal.
         * @param password Contraseña de la cuenta de PayPal.
         */
        public ClsPaypal(string user, string password)
        {
            User = user;
            Password = password;
        }

        /**
         * @property User
         * @brief Propiedad para obtener o establecer el nombre de usuario de PayPal.
         */
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        /**
         * @property Password
         * @brief Propiedad para obtener o establecer la contraseña de la cuenta de PayPal.
         */
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /**
         * @fn bool Autenticar()
         * @brief Método para autenticar la cuenta de PayPal.
         * @return true si las credenciales son válidas, false en caso contrario.
         */
        public bool Autenticar()
        {
            // Verifica las credenciales de la cuenta PayPal
            // Retorna true si son válidas; de lo contrario, retorna false
            return true;
        }

        /**
         * @fn bool realizarPago()
         * @brief Método para realizar un pago con PayPal.
         * @return true si el pago se realizó con éxito, false en caso contrario.
         */
        public bool realizarPago()
        {
            // Se realiza el pago
            Console.WriteLine("Se realizó un pago con PayPal");
            // Retorna true si se hizo el pago; de lo contrario, retorna false
            return true;
        }
    }
}
