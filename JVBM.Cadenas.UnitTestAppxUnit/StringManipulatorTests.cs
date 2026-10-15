using Xunit;
using JVBM.Cadenas;

namespace JVBM.Cadenas.UnitTestAppxUnit
{
    /// <summary>
    /// Pruebas unitarias para la clase StringManipulator usando xUnit.
    /// Valida la correcta manipulación de cadenas de texto.
    /// </summary>
    public class StringManipulatorTests
    {
        // Instancia compartida del manipulador de cadenas
        private readonly StringManipulator _manipulator = new StringManipulator();

        // ══════════════════════════════════════════════════════════════════
        //  GRUPO 1: Pruebas de ReverseString
        // ══════════════════════════════════════════════════════════════════

        /// <summary>
        /// Prueba parametrizada de inversión de cadenas con varios casos.
        /// Cubre: invertir una palabra, una frase, texto con números y cadena de un carácter.
        /// </summary>
        [Theory]
        [InlineData("Hola", "aloH")]                  // Invertir una palabra
        [InlineData("Hola mundo", "odnum aloH")]       // Invertir una frase (con espacio)
        [InlineData("A", "A")]                         // Cadena de un solo carácter
        [InlineData("abc123", "321cba")]               // Texto con números
        [InlineData("12345", "54321")]                 // Solo números
        [InlineData("racecar", "racecar")]             // Palíndromo (igual al invertirlo)
        public void ReverseString_Parametrizado_DebeInvertirCorrectamente(
            string entrada, string resultadoEsperado)
        {
            // Arrange - valores proporcionados por InlineData

            // Act
            string resultado = _manipulator.ReverseString(entrada);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        /// <summary>
        /// Verifica que invertir una cadena vacía retorna una cadena vacía.
        /// </summary>
        [Fact]
        public void ReverseString_CadenaVacia_DebeRetornarCadenaVacia()
        {
            // Arrange
            string entrada = string.Empty;

            // Act
            string resultado = _manipulator.ReverseString(entrada);

            // Assert
            Assert.Equal(string.Empty, resultado);
        }

        /// <summary>
        /// Verifica que invertir una cadena nula retorna cadena vacía
        /// (comportamiento documentado en la clase).
        /// </summary>
        [Fact]
        public void ReverseString_CadenaNula_DebeRetornarCadenaVacia()
        {
            // Arrange
            string? entrada = null;

            // Act
            string resultado = _manipulator.ReverseString(entrada!);

            // Assert
            Assert.Equal(string.Empty, resultado);
        }

        // ══════════════════════════════════════════════════════════════════
        //  GRUPO 2: Pruebas de RemoveSpaces
        // ══════════════════════════════════════════════════════════════════

        /// <summary>
        /// Prueba parametrizada de eliminación de espacios con varios casos.
        /// Cubre: espacios entre palabras, espacios iniciales, finales y múltiples consecutivos.
        /// </summary>
        [Theory]
        [InlineData("Hola mundo", "Holamundo")]            // Espacios entre palabras
        [InlineData(" Hola", "Hola")]                       // Espacio inicial
        [InlineData("Hola ", "Hola")]                       // Espacio final
        [InlineData("Hola   mundo", "Holamundo")]           // Varios espacios consecutivos
        [InlineData("  Hola  mundo  ", "Holamundo")]        // Espacios en todos lados
        [InlineData("SinEspacios", "SinEspacios")]          // Sin espacios (sin cambio)
        public void RemoveSpaces_Parametrizado_DebeEliminarEspaciosCorrectamente(
            string entrada, string resultadoEsperado)
        {
            // Arrange - valores proporcionados por InlineData

            // Act
            string resultado = _manipulator.RemoveSpaces(entrada);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        /// <summary>
        /// Verifica que procesar una cadena sin espacios no modifica el contenido.
        /// </summary>
        [Fact]
        public void RemoveSpaces_SinEspacios_DebeRetornarMismasCadena()
        {
            // Arrange
            string entrada = "SinEspacios";
            string esperado = "SinEspacios";

            // Act
            string resultado = _manipulator.RemoveSpaces(entrada);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        /// <summary>
        /// Verifica que procesar una cadena vacía retorna cadena vacía.
        /// </summary>
        [Fact]
        public void RemoveSpaces_CadenaVacia_DebeRetornarCadenaVacia()
        {
            // Arrange
            string entrada = string.Empty;

            // Act
            string resultado = _manipulator.RemoveSpaces(entrada);

            // Assert
            Assert.Equal(string.Empty, resultado);
        }

        /// <summary>
        /// Verifica que una cadena compuesta solo de espacios retorna cadena vacía.
        /// </summary>
        [Fact]
        public void RemoveSpaces_SoloEspacios_DebeRetornarCadenaVacia()
        {
            // Arrange
            string entrada = "     ";

            // Act
            string resultado = _manipulator.RemoveSpaces(entrada);

            // Assert
            Assert.Equal(string.Empty, resultado);
        }

        // ══════════════════════════════════════════════════════════════════
        //  GRUPO 3: Pruebas de integración (combinando ambos métodos)
        // ══════════════════════════════════════════════════════════════════

        /// <summary>
        /// Verifica que se puede eliminar espacios e invertir en secuencia correctamente.
        /// </summary>
        [Fact]
        public void ReverseString_DespuesDeRemoveSpaces_DebeProducirResultadoCorrecto()
        {
            // Arrange
            string entrada = "Hola mundo";

            // Act: primero eliminamos espacios, luego invertimos
            string sinEspacios = _manipulator.RemoveSpaces(entrada);   // "Holamundo"
            string invertida = _manipulator.ReverseString(sinEspacios); // "odnamualoH"

            // Assert
            Assert.Equal("odnamualoH", invertida);
        }
    }
}
