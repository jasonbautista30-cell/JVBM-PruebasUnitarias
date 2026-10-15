using Microsoft.VisualStudio.TestTools.UnitTesting;
using JVBM.Temperatura;

namespace JVBM.Temperatura.UnitTestMSTest
{
    /// <summary>
    /// Pruebas unitarias para la clase TemperatureConverter usando MSTest.
    /// Valida la correcta conversión entre grados Celsius y Fahrenheit.
    /// </summary>
    [TestClass]
    public class TemperatureConverterTests
    {
        // Tolerancia permitida para comparaciones de números decimales (double)
        private const double Tolerancia = 0.0001;

        // Instancia compartida del convertidor de temperatura
        private TemperatureConverter _converter = new TemperatureConverter();

        // ──────────────────────────────────────────────────────────────────
        // SECCIÓN 1: Conversiones de Celsius a Fahrenheit (casos clásicos)
        // ──────────────────────────────────────────────────────────────────

        /// <summary>
        /// Verifica que 0 °C se convierte correctamente a 32 °F.
        /// (Punto de congelación del agua)
        /// </summary>
        [TestMethod]
        public void CelsiusToFahrenheit_Cero_DebeRetornarTreintaYDos()
        {
            // Arrange
            double celsius = 0.0;
            double fahrenheitEsperado = 32.0;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(fahrenheitEsperado, resultado, Tolerancia,
                "0 °C debe convertirse a 32 °F (punto de congelación).");
        }

        /// <summary>
        /// Verifica que 100 °C se convierte correctamente a 212 °F.
        /// (Punto de ebullición del agua)
        /// </summary>
        [TestMethod]
        public void CelsiusToFahrenheit_CienGrados_DebeRetornarDoscientosDoce()
        {
            // Arrange
            double celsius = 100.0;
            double fahrenheitEsperado = 212.0;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(fahrenheitEsperado, resultado, Tolerancia,
                "100 °C debe convertirse a 212 °F (punto de ebullición).");
        }

        /// <summary>
        /// Verifica que -40 °C se convierte correctamente a -40 °F.
        /// (Punto donde ambas escalas coinciden)
        /// </summary>
        [TestMethod]
        public void CelsiusToFahrenheit_MenosCuarenta_DebeRetornarMenosCuarenta()
        {
            // Arrange
            double celsius = -40.0;
            double fahrenheitEsperado = -40.0;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(fahrenheitEsperado, resultado, Tolerancia,
                "-40 °C debe convertirse a -40 °F (punto de coincidencia de escalas).");
        }

        /// <summary>
        /// Verifica que 25 °C se convierte correctamente a 77 °F.
        /// (Temperatura ambiente típica)
        /// </summary>
        [TestMethod]
        public void CelsiusToFahrenheit_VeinticincoGrados_DebeRetornarSetentaYSiete()
        {
            // Arrange
            double celsius = 25.0;
            double fahrenheitEsperado = 77.0;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(fahrenheitEsperado, resultado, Tolerancia,
                "25 °C debe convertirse a 77 °F (temperatura ambiente).");
        }

        // ──────────────────────────────────────────────────────────────────
        // SECCIÓN 2: Conversiones de Fahrenheit a Celsius (casos clásicos)
        // ──────────────────────────────────────────────────────────────────

        /// <summary>
        /// Verifica que 32 °F se convierte correctamente a 0 °C.
        /// </summary>
        [TestMethod]
        public void FahrenheitToCelsius_TreintaYDos_DebeRetornarCero()
        {
            // Arrange
            double fahrenheit = 32.0;
            double celsiusEsperado = 0.0;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(celsiusEsperado, resultado, Tolerancia,
                "32 °F debe convertirse a 0 °C.");
        }

        /// <summary>
        /// Verifica que 212 °F se convierte correctamente a 100 °C.
        /// </summary>
        [TestMethod]
        public void FahrenheitToCelsius_DoscientosDoce_DebeRetornarCien()
        {
            // Arrange
            double fahrenheit = 212.0;
            double celsiusEsperado = 100.0;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(celsiusEsperado, resultado, Tolerancia,
                "212 °F debe convertirse a 100 °C.");
        }

        /// <summary>
        /// Verifica que -40 °F se convierte correctamente a -40 °C.
        /// </summary>
        [TestMethod]
        public void FahrenheitToCelsius_MenosCuarenta_DebeRetornarMenosCuarenta()
        {
            // Arrange
            double fahrenheit = -40.0;
            double celsiusEsperado = -40.0;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(celsiusEsperado, resultado, Tolerancia,
                "-40 °F debe convertirse a -40 °C.");
        }

        // ──────────────────────────────────────────────────────────────────
        // SECCIÓN 3: Valores decimales y temperaturas negativas adicionales
        // ──────────────────────────────────────────────────────────────────

        /// <summary>
        /// Verifica la conversión de un valor decimal: 36.6 °C (temperatura corporal normal).
        /// </summary>
        [TestMethod]
        public void CelsiusToFahrenheit_TemperaturaCorporal_DebeConvertirCorrectamente()
        {
            // Arrange
            double celsius = 36.6;
            double fahrenheitEsperado = 97.88; // (36.6 × 9/5) + 32 = 97.88

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(fahrenheitEsperado, resultado, Tolerancia,
                "36.6 °C (temperatura corporal) debe convertirse a 97.88 °F.");
        }

        /// <summary>
        /// Verifica la conversión de temperatura negativa adicional: -10 °C a 14 °F.
        /// </summary>
        [TestMethod]
        public void CelsiusToFahrenheit_NegativoDiez_DebeRetornarCatorce()
        {
            // Arrange
            double celsius = -10.0;
            double fahrenheitEsperado = 14.0;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(fahrenheitEsperado, resultado, Tolerancia,
                "-10 °C debe convertirse a 14 °F.");
        }

        // ──────────────────────────────────────────────────────────────────
        // SECCIÓN 4: Pruebas parametrizadas con DataTestMethod y DataRow
        // ──────────────────────────────────────────────────────────────────

        /// <summary>
        /// Prueba parametrizada de conversión Celsius a Fahrenheit con múltiples valores.
        /// Verifica los escenarios con DataRow para cubrir varios casos en una sola prueba.
        /// </summary>
        [TestMethod]
        [DataRow(0.0, 32.0)]
        [DataRow(100.0, 212.0)]
        [DataRow(-40.0, -40.0)]
        [DataRow(25.0, 77.0)]
        [DataRow(-273.15, -459.67)]    // Cero absoluto
        [DataRow(37.0, 98.6)]          // Temperatura corporal estándar
        [DataRow(-20.0, -4.0)]         // Temperatura negativa adicional
        public void CelsiusToFahrenheit_MultiplesValores_DebeConvertirCorrectamente(
            double celsius, double fahrenheitEsperado)
        {
            // Arrange - valores ya proporcionados por DataRow

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(fahrenheitEsperado, resultado, Tolerancia,
                $"{celsius} °C debe convertirse a {fahrenheitEsperado} °F.");
        }

        /// <summary>
        /// Prueba parametrizada de conversión Fahrenheit a Celsius con múltiples valores.
        /// </summary>
        [TestMethod]
        [DataRow(32.0, 0.0)]
        [DataRow(212.0, 100.0)]
        [DataRow(-40.0, -40.0)]
        [DataRow(98.6, 37.0)]         // Temperatura corporal
        [DataRow(-459.67, -273.15)]   // Cero absoluto
        [DataRow(14.0, -10.0)]        // Temperatura fría
        public void FahrenheitToCelsius_MultiplesValores_DebeConvertirCorrectamente(
            double fahrenheit, double celsiusEsperado)
        {
            // Arrange - valores ya proporcionados por DataRow

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(celsiusEsperado, resultado, Tolerancia,
                $"{fahrenheit} °F debe convertirse a {celsiusEsperado} °C.");
        }

        // ──────────────────────────────────────────────────────────────────
        // SECCIÓN 5: Verificación de conversiones de ida y vuelta (round-trip)
        // ──────────────────────────────────────────────────────────────────

        /// <summary>
        /// Verifica que convertir de Celsius a Fahrenheit y luego de vuelta a Celsius
        /// produce el valor original (conversión de ida y vuelta).
        /// </summary>
        [TestMethod]
        public void ConversionIdaYVuelta_CelsiusAFahrenheitYVuelta_DebeRetornarOriginal()
        {
            // Arrange
            double celsiusOriginal = 37.5;

            // Act: Celsius → Fahrenheit → Celsius
            double fahrenheit = _converter.CelsiusToFahrenheit(celsiusOriginal);
            double celsiusResultante = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(celsiusOriginal, celsiusResultante, Tolerancia,
                "La conversión Celsius → Fahrenheit → Celsius debe retornar el valor original.");
        }

        /// <summary>
        /// Verifica que convertir de Fahrenheit a Celsius y luego de vuelta a Fahrenheit
        /// produce el valor original (conversión de ida y vuelta).
        /// </summary>
        [TestMethod]
        public void ConversionIdaYVuelta_FahrenheitACelsiusYVuelta_DebeRetornarOriginal()
        {
            // Arrange
            double fahrenheitOriginal = 98.6;

            // Act: Fahrenheit → Celsius → Fahrenheit
            double celsius = _converter.FahrenheitToCelsius(fahrenheitOriginal);
            double fahrenheitResultante = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(fahrenheitOriginal, fahrenheitResultante, Tolerancia,
                "La conversión Fahrenheit → Celsius → Fahrenheit debe retornar el valor original.");
        }
    }
}
