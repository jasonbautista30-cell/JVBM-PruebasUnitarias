# Documentación de Casos de Prueba — Azure DevOps
## Práctica 1: Pruebas Unitarias con MSTest y xUnit
**Estudiante:** Jason Vladymir Bautista Maravilla  
**Docente:** Gerber Alexis Gómez Hidalgo  
**Institución:** ESFE ÁGAPE  
**Fecha de elaboración:** 15 de octubre de 2026

---

> **Nota:** Este documento contiene todos los casos de prueba organizados y listos para registrar en Azure DevOps (sección *Test Plans → Test Cases*). Si tienes acceso a la plataforma, copia cada caso según los identificadores indicados.

---

## EJERCICIO 1 — Convertidor de Temperatura (MSTest)

### Proyecto: `JVBM.Temperatura` / `JVBM.Temperatura.UnitTestMSTest`
### Framework de pruebas: MSTest v3

---

| ID | Nombre del Caso | Objetivo |
|----|----------------|----------|
| MST-001 | Conversión 0 °C a 32 °F | Verificar el punto de congelación del agua |
| MST-002 | Conversión 100 °C a 212 °F | Verificar el punto de ebullición del agua |
| MST-003 | Conversión -40 °C a -40 °F | Verificar el punto de coincidencia de escalas |
| MST-004 | Conversión 25 °C a 77 °F | Verificar temperatura ambiente típica |
| MST-005 | Conversión 32 °F a 0 °C | Verificar punto de congelación inverso |
| MST-006 | Conversión 212 °F a 100 °C | Verificar punto de ebullición inverso |
| MST-007 | Conversión -40 °F a -40 °C | Verificar coincidencia de escalas inverso |
| MST-008 | Conversión de valor decimal (temperatura corporal) | Verificar precisión en valores decimales |
| MST-009 | Conversión temperatura negativa (-10 °C a 14 °F) | Verificar temperaturas negativas |
| MST-010 | Prueba parametrizada Celsius→Fahrenheit (7 casos) | Cubrir múltiples valores en una sola prueba |
| MST-011 | Prueba parametrizada Fahrenheit→Celsius (6 casos) | Cubrir múltiples valores inversos |
| MST-012 | Conversión de ida y vuelta C→F→C | Verificar consistencia matemática |
| MST-013 | Conversión de ida y vuelta F→C→F | Verificar consistencia matemática inversa |

---

### MST-001 — Conversión 0 °C a 32 °F

| Campo | Detalle |
|-------|---------|
| **Nombre** | CelsiusToFahrenheit_Cero_DebeRetornarTreintaYDos |
| **Objetivo** | Verificar que 0 °C se convierte correctamente a 32 °F (punto de congelación del agua) |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | celsius = 0.0 |
| **Pasos** | 1. Crear instancia de `TemperatureConverter` <br>2. Llamar a `CelsiusToFahrenheit(0.0)` |
| **Resultado esperado** | 32.0 °F (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ 32.0 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-002 — Conversión 100 °C a 212 °F

| Campo | Detalle |
|-------|---------|
| **Nombre** | CelsiusToFahrenheit_CienGrados_DebeRetornarDoscientosDoce |
| **Objetivo** | Verificar que 100 °C se convierte correctamente a 212 °F (punto de ebullición del agua) |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | celsius = 100.0 |
| **Pasos** | 1. Crear instancia de `TemperatureConverter` <br>2. Llamar a `CelsiusToFahrenheit(100.0)` |
| **Resultado esperado** | 212.0 °F (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ 212.0 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-003 — Conversión -40 °C a -40 °F

| Campo | Detalle |
|-------|---------|
| **Nombre** | CelsiusToFahrenheit_MenosCuarenta_DebeRetornarMenosCuarenta |
| **Objetivo** | Verificar el único punto donde Celsius y Fahrenheit coinciden (-40°) |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | celsius = -40.0 |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `CelsiusToFahrenheit(-40.0)` |
| **Resultado esperado** | -40.0 °F (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ -40.0 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-004 — Conversión 25 °C a 77 °F

| Campo | Detalle |
|-------|---------|
| **Nombre** | CelsiusToFahrenheit_VeinticincoGrados_DebeRetornarSetentaYSiete |
| **Objetivo** | Verificar conversión de temperatura ambiente típica |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | celsius = 25.0 |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `CelsiusToFahrenheit(25.0)` |
| **Resultado esperado** | 77.0 °F (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ 77.0 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-005 — Conversión 32 °F a 0 °C

| Campo | Detalle |
|-------|---------|
| **Nombre** | FahrenheitToCelsius_TreintaYDos_DebeRetornarCero |
| **Objetivo** | Verificar conversión inversa del punto de congelación |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | fahrenheit = 32.0 |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `FahrenheitToCelsius(32.0)` |
| **Resultado esperado** | 0.0 °C (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ 0.0 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-006 — Conversión 212 °F a 100 °C

| Campo | Detalle |
|-------|---------|
| **Nombre** | FahrenheitToCelsius_DoscientosDoce_DebeRetornarCien |
| **Objetivo** | Verificar conversión inversa del punto de ebullición |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | fahrenheit = 212.0 |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `FahrenheitToCelsius(212.0)` |
| **Resultado esperado** | 100.0 °C (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ 100.0 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-007 — Conversión -40 °F a -40 °C

| Campo | Detalle |
|-------|---------|
| **Nombre** | FahrenheitToCelsius_MenosCuarenta_DebeRetornarMenosCuarenta |
| **Objetivo** | Verificar coincidencia de escalas en dirección inversa |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | fahrenheit = -40.0 |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `FahrenheitToCelsius(-40.0)` |
| **Resultado esperado** | -40.0 °C (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ -40.0 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-008 — Conversión de valor decimal (temperatura corporal)

| Campo | Detalle |
|-------|---------|
| **Nombre** | CelsiusToFahrenheit_TemperaturaCorporal_DebeConvertirCorrectamente |
| **Objetivo** | Verificar precisión en conversión de valores decimales |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | celsius = 36.6 |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `CelsiusToFahrenheit(36.6)` |
| **Resultado esperado** | 97.88 °F (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ 97.88 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-009 — Conversión temperatura negativa adicional (-10 °C a 14 °F)

| Campo | Detalle |
|-------|---------|
| **Nombre** | CelsiusToFahrenheit_NegativoDiez_DebeRetornarCatorce |
| **Objetivo** | Verificar conversión de temperatura bajo cero adicional |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | celsius = -10.0 |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `CelsiusToFahrenheit(-10.0)` |
| **Resultado esperado** | 14.0 °F (con tolerancia de ±0.0001) |
| **Resultado real** | ✅ 14.0 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-010 — Prueba parametrizada Celsius→Fahrenheit (7 valores)

| Campo | Detalle |
|-------|---------|
| **Nombre** | CelsiusToFahrenheit_MultiplesValores_DebeConvertirCorrectamente |
| **Objetivo** | Verificar múltiples conversiones C→F en una sola prueba parametrizada |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entradas** | (0→32), (100→212), (-40→-40), (25→77), (-273.15→-459.67), (37→98.6), (-20→-4) |
| **Pasos** | 1. Crear instancia <br>2. Para cada DataRow, llamar a `CelsiusToFahrenheit(celsius)` |
| **Resultado esperado** | Cada conversión retorna el fahrenheit esperado (tolerancia ±0.0001) |
| **Resultado real** | ✅ 7/7 filas — APROBADO |
| **Método de prueba** | `[DataTestMethod]` + `[DataRow]` |

---

### MST-011 — Prueba parametrizada Fahrenheit→Celsius (6 valores)

| Campo | Detalle |
|-------|---------|
| **Nombre** | FahrenheitToCelsius_MultiplesValores_DebeConvertirCorrectamente |
| **Objetivo** | Verificar múltiples conversiones F→C en una sola prueba parametrizada |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entradas** | (32→0), (212→100), (-40→-40), (98.6→37), (-459.67→-273.15), (14→-10) |
| **Pasos** | 1. Crear instancia <br>2. Para cada DataRow, llamar a `FahrenheitToCelsius(fahrenheit)` |
| **Resultado esperado** | Cada conversión retorna el celsius esperado (tolerancia ±0.0001) |
| **Resultado real** | ✅ 6/6 filas — APROBADO |
| **Método de prueba** | `[DataTestMethod]` + `[DataRow]` |

---

### MST-012 — Conversión de ida y vuelta C→F→C

| Campo | Detalle |
|-------|---------|
| **Nombre** | ConversionIdaYVuelta_CelsiusAFahrenheitYVuelta_DebeRetornarOriginal |
| **Objetivo** | Verificar consistencia matemática en conversión de ida y vuelta |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | celsius = 37.5 |
| **Pasos** | 1. Crear instancia <br>2. `fahrenheit = CelsiusToFahrenheit(37.5)` <br>3. `resultado = FahrenheitToCelsius(fahrenheit)` |
| **Resultado esperado** | resultado ≈ 37.5 (tolerancia ±0.0001) |
| **Resultado real** | ✅ 37.5 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

### MST-013 — Conversión de ida y vuelta F→C→F

| Campo | Detalle |
|-------|---------|
| **Nombre** | ConversionIdaYVuelta_FahrenheitACelsiusYVuelta_DebeRetornarOriginal |
| **Objetivo** | Verificar consistencia matemática en conversión inversa de ida y vuelta |
| **Precondiciones** | La clase `TemperatureConverter` debe estar instanciada |
| **Entrada** | fahrenheit = 98.6 |
| **Pasos** | 1. Crear instancia <br>2. `celsius = FahrenheitToCelsius(98.6)` <br>3. `resultado = CelsiusToFahrenheit(celsius)` |
| **Resultado esperado** | resultado ≈ 98.6 (tolerancia ±0.0001) |
| **Resultado real** | ✅ 98.6 — APROBADO |
| **Método de prueba** | `[TestMethod]` |

---

## EJERCICIO 2 — Manipulación de Cadenas (xUnit)

### Proyecto: `JVBM.Cadenas` / `JVBM.Cadenas.UnitTestAppxUnit`
### Framework de pruebas: xUnit v2

---

| ID | Nombre del Caso | Objetivo |
|----|----------------|----------|
| XUN-001 | Invertir una palabra | Verificar inversión básica de caracteres |
| XUN-002 | Invertir una frase | Verificar inversión con espacios |
| XUN-003 | Invertir cadena vacía | Verificar manejo de cadena vacía |
| XUN-004 | Invertir cadena de un carácter | Verificar caso límite de un carácter |
| XUN-005 | Invertir texto con números | Verificar inversión de cadenas mixtas |
| XUN-006 | Eliminar espacios entre palabras | Verificar eliminación básica de espacios |
| XUN-007 | Eliminar espacio inicial | Verificar eliminación de espacio al inicio |
| XUN-008 | Eliminar espacio final | Verificar eliminación de espacio al final |
| XUN-009 | Eliminar varios espacios consecutivos | Verificar eliminación de múltiples espacios |
| XUN-010 | Procesar cadena sin espacios | Verificar que no modifica cadenas sin espacios |
| XUN-011 | ReverseString con cadena nula | Verificar manejo de null |
| XUN-012 | RemoveSpaces con cadena vacía | Verificar manejo de cadena vacía |
| XUN-013 | RemoveSpaces con solo espacios | Verificar que retorna vacío cuando todo es espacios |
| XUN-014 | Combinación: RemoveSpaces + ReverseString | Verificar composición de métodos |

---

### XUN-001 — Invertir una palabra

| Campo | Detalle |
|-------|---------|
| **Nombre** | ReverseString_Parametrizado_DebeInvertirCorrectamente (InlineData "Hola") |
| **Objetivo** | Verificar que una palabra simple se invierte correctamente carácter por carácter |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "Hola" |
| **Pasos** | 1. Crear instancia de `StringManipulator` <br>2. Llamar a `ReverseString("Hola")` |
| **Resultado esperado** | "aloH" |
| **Resultado real** | ✅ "aloH" — APROBADO |
| **Método de prueba** | `[Theory]` + `[InlineData]` |

---

### XUN-002 — Invertir una frase

| Campo | Detalle |
|-------|---------|
| **Nombre** | ReverseString_Parametrizado_DebeInvertirCorrectamente (InlineData "Hola mundo") |
| **Objetivo** | Verificar que una frase con espacio se invierte respetando el espacio como carácter |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "Hola mundo" |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `ReverseString("Hola mundo")` |
| **Resultado esperado** | "odnum aloH" |
| **Resultado real** | ✅ "odnum aloH" — APROBADO |
| **Método de prueba** | `[Theory]` + `[InlineData]` |

---

### XUN-003 — Invertir cadena vacía

| Campo | Detalle |
|-------|---------|
| **Nombre** | ReverseString_CadenaVacia_DebeRetornarCadenaVacia |
| **Objetivo** | Verificar que una cadena vacía permanece vacía al invertirse |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "" (string.Empty) |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `ReverseString("")` |
| **Resultado esperado** | "" (cadena vacía) |
| **Resultado real** | ✅ "" — APROBADO |
| **Método de prueba** | `[Fact]` |

---

### XUN-004 — Invertir cadena de un carácter

| Campo | Detalle |
|-------|---------|
| **Nombre** | ReverseString_Parametrizado_DebeInvertirCorrectamente (InlineData "A") |
| **Objetivo** | Verificar caso límite: una cadena de un solo carácter |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "A" |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `ReverseString("A")` |
| **Resultado esperado** | "A" |
| **Resultado real** | ✅ "A" — APROBADO |
| **Método de prueba** | `[Theory]` + `[InlineData]` |

---

### XUN-005 — Invertir texto con números

| Campo | Detalle |
|-------|---------|
| **Nombre** | ReverseString_Parametrizado_DebeInvertirCorrectamente (InlineData "abc123") |
| **Objetivo** | Verificar que texto alfanumérico se invierte correctamente |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "abc123" |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `ReverseString("abc123")` |
| **Resultado esperado** | "321cba" |
| **Resultado real** | ✅ "321cba" — APROBADO |
| **Método de prueba** | `[Theory]` + `[InlineData]` |

---

### XUN-006 — Eliminar espacios entre palabras

| Campo | Detalle |
|-------|---------|
| **Nombre** | RemoveSpaces_Parametrizado_DebeEliminarEspaciosCorrectamente (InlineData "Hola mundo") |
| **Objetivo** | Verificar eliminación de espacio entre palabras |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "Hola mundo" |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `RemoveSpaces("Hola mundo")` |
| **Resultado esperado** | "Holamundo" |
| **Resultado real** | ✅ "Holamundo" — APROBADO |
| **Método de prueba** | `[Theory]` + `[InlineData]` |

---

### XUN-007 — Eliminar espacio inicial

| Campo | Detalle |
|-------|---------|
| **Nombre** | RemoveSpaces_Parametrizado_DebeEliminarEspaciosCorrectamente (InlineData " Hola") |
| **Objetivo** | Verificar eliminación de espacio al inicio de la cadena |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = " Hola" (con espacio al inicio) |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `RemoveSpaces(" Hola")` |
| **Resultado esperado** | "Hola" |
| **Resultado real** | ✅ "Hola" — APROBADO |
| **Método de prueba** | `[Theory]` + `[InlineData]` |

---

### XUN-008 — Eliminar espacio final

| Campo | Detalle |
|-------|---------|
| **Nombre** | RemoveSpaces_Parametrizado_DebeEliminarEspaciosCorrectamente (InlineData "Hola ") |
| **Objetivo** | Verificar eliminación de espacio al final de la cadena |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "Hola " (con espacio al final) |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `RemoveSpaces("Hola ")` |
| **Resultado esperado** | "Hola" |
| **Resultado real** | ✅ "Hola" — APROBADO |
| **Método de prueba** | `[Theory]` + `[InlineData]` |

---

### XUN-009 — Eliminar varios espacios consecutivos

| Campo | Detalle |
|-------|---------|
| **Nombre** | RemoveSpaces_Parametrizado_DebeEliminarEspaciosCorrectamente (InlineData "Hola   mundo") |
| **Objetivo** | Verificar que múltiples espacios consecutivos se eliminan todos |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "Hola   mundo" (3 espacios) |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `RemoveSpaces("Hola   mundo")` |
| **Resultado esperado** | "Holamundo" |
| **Resultado real** | ✅ "Holamundo" — APROBADO |
| **Método de prueba** | `[Theory]` + `[InlineData]` |

---

### XUN-010 — Procesar cadena sin espacios

| Campo | Detalle |
|-------|---------|
| **Nombre** | RemoveSpaces_SinEspacios_DebeRetornarMismasCadena |
| **Objetivo** | Verificar que una cadena sin espacios no se modifica |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "SinEspacios" |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `RemoveSpaces("SinEspacios")` |
| **Resultado esperado** | "SinEspacios" |
| **Resultado real** | ✅ "SinEspacios" — APROBADO |
| **Método de prueba** | `[Fact]` |

---

### XUN-011 — ReverseString con cadena nula

| Campo | Detalle |
|-------|---------|
| **Nombre** | ReverseString_CadenaNula_DebeRetornarCadenaVacia |
| **Objetivo** | Verificar que el método maneja `null` sin lanzar excepciones |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = null |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `ReverseString(null)` |
| **Resultado esperado** | "" (cadena vacía, sin NullReferenceException) |
| **Resultado real** | ✅ "" — APROBADO |
| **Método de prueba** | `[Fact]` |

---

### XUN-012 — RemoveSpaces con cadena vacía

| Campo | Detalle |
|-------|---------|
| **Nombre** | RemoveSpaces_CadenaVacia_DebeRetornarCadenaVacia |
| **Objetivo** | Verificar que una cadena vacía permanece vacía |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "" (string.Empty) |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `RemoveSpaces("")` |
| **Resultado esperado** | "" (cadena vacía) |
| **Resultado real** | ✅ "" — APROBADO |
| **Método de prueba** | `[Fact]` |

---

### XUN-013 — RemoveSpaces con solo espacios

| Campo | Detalle |
|-------|---------|
| **Nombre** | RemoveSpaces_SoloEspacios_DebeRetornarCadenaVacia |
| **Objetivo** | Verificar que una cadena de solo espacios retorna cadena vacía |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "     " (5 espacios) |
| **Pasos** | 1. Crear instancia <br>2. Llamar a `RemoveSpaces("     ")` |
| **Resultado esperado** | "" (cadena vacía) |
| **Resultado real** | ✅ "" — APROBADO |
| **Método de prueba** | `[Fact]` |

---

### XUN-014 — Combinación: RemoveSpaces + ReverseString

| Campo | Detalle |
|-------|---------|
| **Nombre** | ReverseString_DespuesDeRemoveSpaces_DebeProducirResultadoCorrecto |
| **Objetivo** | Verificar que los dos métodos funcionan correctamente en secuencia |
| **Precondiciones** | La clase `StringManipulator` debe estar instanciada |
| **Entrada** | input = "Hola mundo" |
| **Pasos** | 1. Crear instancia <br>2. `sinEspacios = RemoveSpaces("Hola mundo")` → "Holamundo" <br>3. `resultado = ReverseString("Holamundo")` |
| **Resultado esperado** | "odnumaloH" (H-o-l-a-m-u-n-d-o invertido = o-d-n-u-m-a-l-o-H) |
| **Resultado real** | ✅ "odnumaloH" — APROBADO |
| **Método de prueba** | `[Fact]` |

---

## Instrucciones para registrar en Azure DevOps

1. Inicia sesión en **dev.azure.com** con tu cuenta institucional.
2. Selecciona tu organización y el proyecto asignado.
3. Ve a **Test Plans** en el menú lateral izquierdo.
4. Crea un nuevo Test Plan llamado: `Práctica 1 - Pruebas Unitarias JVBM`
5. Crea dos Test Suites dentro del plan:
   - `Ejercicio 1 - MSTest (TemperatureConverter)`
   - `Ejercicio 2 - xUnit (StringManipulator)`
6. En cada suite, crea los Test Cases usando los datos de las tablas anteriores.
7. Para cada caso, completa: Título, Pasos, Resultado esperado.
8. Al ejecutar las pruebas, marca el resultado real como **Passed** si `dotnet test` lo confirma.

---

*Documento generado el 15 de octubre de 2026 — ESFE ÁGAPE*
