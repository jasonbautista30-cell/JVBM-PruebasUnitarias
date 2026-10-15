namespace JVBM.Cadenas
{
    /// <summary>
    /// Clase que proporciona métodos para manipular cadenas de texto.
    /// </summary>
    public class StringManipulator
    {
        /// <summary>
        /// Invierte el orden de los caracteres de una cadena de texto.
        /// Ejemplo: "Hola" → "aloH"
        ///
        /// Comportamiento especial:
        /// - Cadena nula (null): se retorna cadena vacía ("").
        /// - Cadena vacía (""): se retorna cadena vacía ("").
        /// - Cadena de un carácter: se retorna el mismo carácter.
        /// - Espacios en blanco: se consideran caracteres y se invierten junto con el resto.
        /// </summary>
        /// <param name="input">La cadena de entrada a invertir.</param>
        /// <returns>La cadena con los caracteres en orden inverso.</returns>
        public string ReverseString(string input)
        {
            // Si la entrada es nula, retornar cadena vacía
            if (input == null)
                return string.Empty;

            // Si la cadena está vacía o tiene un solo carácter, retornarla tal cual
            if (input.Length <= 1)
                return input;

            // Convertir la cadena en un arreglo de caracteres, invertirlo y volver a unirlo
            char[] caracteres = input.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }

        /// <summary>
        /// Elimina los espacios en blanco convencionales (espacio ASCII 32)
        /// de la cadena de entrada.
        /// Ejemplo: "Hola mundo" → "Holamundo"
        ///
        /// Comportamiento especial:
        /// - Cadena nula (null): se retorna cadena vacía ("").
        /// - Cadena vacía (""): se retorna cadena vacía ("").
        /// - Espacios iniciales y finales: también son eliminados.
        /// - Múltiples espacios consecutivos: todos son eliminados.
        /// - Solo se eliminan espacios convencionales (char 32), no tabulaciones ni saltos de línea.
        /// </summary>
        /// <param name="input">La cadena de entrada de la cual se eliminarán los espacios.</param>
        /// <returns>La cadena sin espacios en blanco convencionales.</returns>
        public string RemoveSpaces(string input)
        {
            // Si la entrada es nula, retornar cadena vacía
            if (input == null)
                return string.Empty;

            // Reemplazar todos los espacios convencionales (espacio ASCII 32) por nada
            return input.Replace(" ", string.Empty);
        }
    }
}
