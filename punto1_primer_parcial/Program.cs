/**
 * @file Programa Principal
 * @brief Este archivo contiene la clase principal Program para la aplicación de gestión de acciones financieras.
 */

using System;
using punto1_primer_parcial.Controlador;
using punto1_primer_parcial.Modelo;
using punto1_primer_parcial.Vista;

namespace punto1_primer_parcial
{
    /**
     * @class Program
     * @brief Clase principal que contiene el punto de entrada Main de la aplicación.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear una instancia del modelo de acciones.
            ModeloAccion modelo = new ModeloAccion();

            // Crear una instancia de la vista de acciones y pasarle el modelo.
            VistaAccion vista = new VistaAccion(modelo);

            // Crear una instancia del observador de acciones de texto.
            IObservadorAccion observador = new ObservadorAccionTexto();

            // Crear una instancia del controlador de acciones y pasarle el modelo, la vista y el observador.
            ControladorAccion controlador = new ControladorAccion(modelo, vista, observador);

            // Agregar acciones al modelo con sus respectivos atributos.
            controlador.agregarAccion("Arepas Doña Filipina", 30000.0, 40000.0, 50000.0, 20000.0);
            controlador.agregarAccion("Cafe Juan el Pez", 100000.0, 120000.0, 200000.0, 50000.0);

            // Mostrar las acciones.
            vista.mostrarAcciones();

            // Actualizar el precio de la Accion1 y Accion2.
            controlador.actualizarPrecio("Arepas Doña Filipina", 42000.0);
            controlador.actualizarPrecio("Cafe Juan el Pez", 210000.0);

            // Mostrar las acciones actualizadas en la vista.
            vista.mostrarAcciones();

            // Eliminar la Accion1 del modelo.
            controlador.eliminarAccion("Arepas Doña Filipina");

            // Mostrar las acciones después de la eliminación.
            vista.mostrarAcciones();

            // Actualizar el precio de la Accion2.
            controlador.actualizarPrecio("Cafe Juan el Pez", 48000.0);

            // Mostrar las acciones actualizadas en la vista.
            vista.mostrarAcciones();

            // Esperar a que el usuario presione una tecla antes de salir.
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
