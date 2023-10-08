/**
 * @file ClsTargetaCredito.cs
 * @brief Definición de la clase ClsTargetaCredito.
 */

using System;

namespace punto2_primer_parcial.Program
{
    /**
     * @class ClsTargetaCredito
     * @brief Clase que representa una tarjeta de crédito y cumple con las interfaces ILlenarInfo, IPago e IAutenticar.
     */
    public class ClsTargetaCredito : ILlenarInfo, IPago, IAutenticar
    {
        private string nombreTitular;
        private int numTargetaCredito;
        private DateTime fechaVencimiento;
        private int codigoSeguridad;

        /**
         * @brief Constructor por defecto de ClsTargetaCredito.
         */
        public ClsTargetaCredito()
        {
        }

        /**
         * @brief Constructor parametrizado de ClsTargetaCredito.
         * @param nombreTitular Nombre del titular de la tarjeta.
         * @param numTargetaCredito Número de la tarjeta de crédito.
         * @param fechaVencimiento Fecha de vencimiento de la tarjeta.
         * @param codigoSeguridad Código de seguridad de la tarjeta.
         */
        public ClsTargetaCredito(string nombreTitular, int numTargetaCredito, DateTime fechaVencimiento, int codigoSeguridad)
        {
            NombreTitular = nombreTitular;
            NumTargetaCredito = numTargetaCredito;
            FechaVencimiento = fechaVencimiento;
            CodigoSeguridad = codigoSeguridad;
        }

        /**
         * @property NombreTitular
         * @brief Propiedad para obtener o establecer el nombre del titular de la tarjeta.
         */
        public string NombreTitular
        {
            get { return nombreTitular; }
            set { nombreTitular = value; }
        }

        /**
         * @property NumTargetaCredito
         * @brief Propiedad para obtener o establecer el número de la tarjeta de crédito.
         */
        public int NumTargetaCredito
        {
            get { return numTargetaCredito; }
            set { numTargetaCredito = value; }
        }

        /**
         * @property FechaVencimiento
         * @brief Propiedad para obtener o establecer la fecha de vencimiento de la tarjeta.
         */
        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        /**
         * @property CodigoSeguridad
         * @brief Propiedad para obtener o establecer el código de seguridad de la tarjeta.
         */
        public int CodigoSeguridad
        {
            get { return codigoSeguridad; }
            set { codigoSeguridad = value; }
        }

        /**
         * @fn void llenarInfo()
         * @brief Método para llenar información de la tarjeta de crédito.
         */
        public void llenarInfo()
        {
            // Se llena la información de la tarjeta de crédito
        }

        /**
         * @fn bool Autenticar()
         * @brief Método para autenticar la tarjeta de crédito.
         * @return true si la autenticación es exitosa (cumple con el límite), false en caso contrario.
         */
        public bool Autenticar()
        {
            // Se verifica el límite de la tarjeta de crédito
            // Si cumple con el límite, retorna true; de lo contrario, retorna false
            return true;
        }

        /**
         * @fn bool realizarPago()
         * @brief Método para realizar un pago con tarjeta de crédito.
         * @return true si el pago se realizó con éxito, false en caso contrario.
         */
        public bool realizarPago()
        {
            // Se realiza el pago
            Console.WriteLine("Se realizó un pago con Tarjeta de Crédito");
            // Retorna true si se hizo el pago; de lo contrario, retorna false
            return true;
        }
    }
}
