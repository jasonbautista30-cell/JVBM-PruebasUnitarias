# Práctica 1: Pruebas Unitarias con MSTest y xUnit

**Estudiante:** Jason Vladymir Bautista Maravilla  
**Docente:** Gerber Alexis Gómez Hidalgo  
**Institución:** ESFE ÁGAPE  
**Fecha:** Octubre 2026  

---

## Objetivo

Aplicar los conceptos de pruebas unitarias en C# utilizando los frameworks **MSTest** y **xUnit**, desarrollando dos ejercicios prácticos:

1. **Convertidor de Temperatura** — probado con MSTest
2. **Manipulador de Cadenas** — probado con xUnit

---

## Herramientas utilizadas

| Herramienta | Versión | Propósito |
|-------------|---------|-----------|
| .NET SDK | 8.0 | Framework de desarrollo |
| MSTest | v3 | Framework de pruebas unitarias (Ejercicio 1) |
| xUnit | v2 | Framework de pruebas unitarias (Ejercicio 2) |
| Git | 2.53 | Control de versiones |
| GitHub | — | Repositorio remoto |
| PowerShell | 5+ | Terminal de comandos |

---

## ¿Qué es MSTest?

**MSTest** es el framework de pruebas unitarias oficial de Microsoft para .NET. Utiliza atributos como:

- `[TestClass]` — marca una clase como contenedor de pruebas
- `[TestMethod]` — marca un método como caso de prueba individual
- `[DataRow(...)]` — permite pruebas parametrizadas con múltiples valores
- `Assert.AreEqual(esperado, actual, tolerancia)` — verifica que dos valores son iguales

Es el framework integrado en Visual Studio y Azure DevOps para la gestión de pruebas.

---

## ¿Qué es xUnit?

**xUnit** es un framework de pruebas unitarias moderno y extensible para .NET, ampliamente adoptado en proyectos open source. Utiliza:

- `[Fact]` — marca una prueba unitaria simple sin parámetros
- `[Theory]` — marca una prueba parametrizada
- `[InlineData(...)]` — provee los datos de entrada para una teoría
- `Assert.Equal(esperado, actual)` — verifica igualdad de valores

Se diferencia de MSTest por tener un diseño más limpio y mejor soporte para inyección de dependencias en pruebas.

---

## Estructura de la solución

```
Practica1-PruebasUnitarias/
├── JVBM.PruebasUnitarias.slnx          ← Solución .NET
├── .gitignore
├── README.md
├── Documentacion_AzureDevOps.md
├── Evidencias/                          ← Capturas de pantalla
│
├── JVBM.Temperatura/                    ← Biblioteca de clases
│   ├── JVBM.Temperatura.csproj
│   └── TemperatureConverter.cs
│
├── JVBM.Temperatura.UnitTestMSTest/     ← Pruebas MSTest
│   ├── JVBM.Temperatura.UnitTestMSTest.csproj
│   └── TemperatureConverterTests.cs
│
├── JVBM.Cadenas/                        ← Biblioteca de clases
│   ├── JVBM.Cadenas.csproj
│   └── StringManipulator.cs
│
└── JVBM.Cadenas.UnitTestAppxUnit/       ← Pruebas xUnit
    ├── JVBM.Cadenas.UnitTestAppxUnit.csproj
    └── StringManipulatorTests.cs
```

---

## Ejercicio 1 — Convertidor de Temperatura

### Clase: `TemperatureConverter` (proyecto `JVBM.Temperatura`)

Convierte temperaturas entre las escalas Celsius y Fahrenheit.

#### Métodos

| Método | Firma | Descripción |
|--------|-------|-------------|
| `CelsiusToFahrenheit` | `double CelsiusToFahrenheit(double celsius)` | Convierte Celsius a Fahrenheit: `F = (C × 9/5) + 32` |
| `FahrenheitToCelsius` | `double FahrenheitToCelsius(double fahrenheit)` | Convierte Fahrenheit a Celsius: `C = (F − 32) × 5/9` |

#### Ejemplos de conversión

| Celsius (°C) | Fahrenheit (°F) |
|:---:|:---:|
| 0 | 32 |
| 100 | 212 |
| -40 | -40 |
| 25 | 77 |
| 37 | 98.6 |

---

## Ejercicio 2 — Manipulador de Cadenas

### Clase: `StringManipulator` (proyecto `JVBM.Cadenas`)

Realiza operaciones de manipulación sobre cadenas de texto.

#### Métodos

| Método | Firma | Descripción |
|--------|-------|-------------|
| `ReverseString` | `string ReverseString(string input)` | Invierte el orden de los caracteres de la cadena |
| `RemoveSpaces` | `string RemoveSpaces(string input)` | Elimina todos los espacios convencionales (ASCII 32) |

#### Ejemplos

| Método | Entrada | Salida |
|--------|---------|--------|
| `ReverseString` | `"Hola"` | `"aloH"` |
| `ReverseString` | `"Hola mundo"` | `"odnum aloH"` |
| `RemoveSpaces` | `"Hola mundo"` | `"Holamundo"` |
| `RemoveSpaces` | `"  Hola  "` | `"Hola"` |

#### Comportamiento con casos especiales

| Caso | `ReverseString` | `RemoveSpaces` |
|------|-----------------|----------------|
| `null` | Retorna `""` | Retorna `""` |
| `""` (vacío) | Retorna `""` | Retorna `""` |
| Un carácter | Retorna el mismo carácter | Retorna el mismo carácter |
| Solo espacios | Invierte los espacios | Retorna `""` |

---

## Instrucciones para ejecutar las pruebas

### Prerrequisitos
- .NET SDK 8.0 o superior instalado
- Git instalado (para clonar el repositorio)

### Clonar el repositorio
```bash
git clone <URL_DEL_REPOSITORIO>
cd Practica1-PruebasUnitarias
```

### Restaurar dependencias
```bash
dotnet restore JVBM.PruebasUnitarias.slnx
```

### Compilar la solución
```bash
dotnet build JVBM.PruebasUnitarias.slnx
```

### Ejecutar TODAS las pruebas
```bash
dotnet test JVBM.PruebasUnitarias.slnx
```

### Ejecutar solo las pruebas MSTest
```bash
dotnet test JVBM.Temperatura.UnitTestMSTest/JVBM.Temperatura.UnitTestMSTest.csproj
```

### Ejecutar solo las pruebas xUnit
```bash
dotnet test JVBM.Cadenas.UnitTestAppxUnit/JVBM.Cadenas.UnitTestAppxUnit.csproj
```

---

## Resumen de casos de prueba

### MSTest — `TemperatureConverterTests.cs`

| ID | Prueba | Estado |
|----|--------|--------|
| MST-001 | 0 °C → 32 °F | ✅ APROBADO |
| MST-002 | 100 °C → 212 °F | ✅ APROBADO |
| MST-003 | -40 °C → -40 °F | ✅ APROBADO |
| MST-004 | 25 °C → 77 °F | ✅ APROBADO |
| MST-005 | 32 °F → 0 °C | ✅ APROBADO |
| MST-006 | 212 °F → 100 °C | ✅ APROBADO |
| MST-007 | -40 °F → -40 °C | ✅ APROBADO |
| MST-008 | 36.6 °C → 97.88 °F (decimal) | ✅ APROBADO |
| MST-009 | -10 °C → 14 °F (negativo) | ✅ APROBADO |
| MST-010 | Parametrizada C→F (7 DataRows) | ✅ APROBADO |
| MST-011 | Parametrizada F→C (6 DataRows) | ✅ APROBADO |
| MST-012 | Round-trip C→F→C | ✅ APROBADO |
| MST-013 | Round-trip F→C→F | ✅ APROBADO |

### xUnit — `StringManipulatorTests.cs`

| ID | Prueba | Estado |
|----|--------|--------|
| XUN-001 | Invertir "Hola" → "aloH" | ✅ APROBADO |
| XUN-002 | Invertir frase con espacio | ✅ APROBADO |
| XUN-003 | Invertir cadena vacía | ✅ APROBADO |
| XUN-004 | Invertir un carácter | ✅ APROBADO |
| XUN-005 | Invertir texto con números | ✅ APROBADO |
| XUN-006 | Eliminar espacios entre palabras | ✅ APROBADO |
| XUN-007 | Eliminar espacio inicial | ✅ APROBADO |
| XUN-008 | Eliminar espacio final | ✅ APROBADO |
| XUN-009 | Eliminar múltiples espacios | ✅ APROBADO |
| XUN-010 | Sin espacios (sin cambio) | ✅ APROBADO |
| XUN-011 | ReverseString con null | ✅ APROBADO |
| XUN-012 | RemoveSpaces con vacío | ✅ APROBADO |
| XUN-013 | RemoveSpaces con solo espacios | ✅ APROBADO |
| XUN-014 | Combinación de ambos métodos | ✅ APROBADO |

---

## Resultados reales de ejecución

```
Resultado de dotnet test:
  - JVBM.Temperatura.UnitTestMSTest: 22 pruebas ejecutadas, 22 aprobadas, 0 fallidas
  - JVBM.Cadenas.UnitTestAppxUnit:   14 pruebas ejecutadas, 14 aprobadas, 0 fallidas
  - TOTAL: 36 pruebas ejecutadas, 36 aprobadas, 0 fallidas
```

> Los resultados exactos están registrados en la carpeta `Evidencias/`.

---

## Repositorio GitHub

- **URL:** *(se completará después de la publicación)*
- **Visibilidad:** Pública / Privada *(por confirmar con el docente)*

---

## Evidencias disponibles

Las capturas de pantalla se encuentran en la carpeta `Evidencias/` e incluyen:

1. Estructura de la solución con los 4 proyectos
2. Código de `TemperatureConverter.cs`
3. Código de `TemperatureConverterTests.cs`
4. Ejecución exitosa de pruebas MSTest
5. Código de `StringManipulator.cs`
6. Código de `StringManipulatorTests.cs`
7. Ejecución exitosa de pruebas xUnit
8. Resultado general de `dotnet test`
9. Historial de commits de Git

---

## Limitaciones y pasos pendientes

- [ ] Publicar en GitHub (requiere confirmación del estudiante sobre visibilidad del repositorio)
- [ ] Registrar los casos de prueba en Azure DevOps (requiere acceso a la organización)
- [ ] Tomar capturas de pantalla manuales que muestren la fecha y hora del sistema

---

*Práctica 1 — Pruebas Unitarias con MSTest y xUnit — ESFE ÁGAPE — Octubre 2026*
