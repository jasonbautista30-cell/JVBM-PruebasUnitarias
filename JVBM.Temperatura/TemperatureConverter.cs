namespace JVBM.Temperatura
{
    /// <summary>
    /// Clase que proporciona métodos para convertir temperaturas
    /// entre las escalas Celsius y Fahrenheit.
    /// </summary>
    public class TemperatureConverter
    {
        /// <summary>
        /// Convierte una temperatura de grados Celsius a grados Fahrenheit.
        /// Fórmula: Fahrenheit = (Celsius × 9 / 5) + 32
        /// </summary>
        /// <param name="celsius">Temperatura en grados Celsius.</param>
        /// <returns>Temperatura equivalente en grados Fahrenheit.</returns>
        public double CelsiusToFahrenheit(double celsius)
        {
            // Aplicar la fórmula de conversión: F = (C × 9/5) + 32
            return (celsius * 9.0 / 5.0) + 32.0;
        }

        /// <summary>
        /// Convierte una temperatura de grados Fahrenheit a grados Celsius.
        /// Fórmula: Celsius = (Fahrenheit − 32) × 5 / 9
        /// </summary>
        /// <param name="fahrenheit">Temperatura en grados Fahrenheit.</param>
        /// <returns>Temperatura equivalente en grados Celsius.</returns>
        public double FahrenheitToCelsius(double fahrenheit)
        {
            // Aplicar la fórmula de conversión: C = (F - 32) × 5/9
            return (fahrenheit - 32.0) * 5.0 / 9.0;
        }
    }
}
