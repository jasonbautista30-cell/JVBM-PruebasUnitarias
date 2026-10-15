# RESUMEN DE ENTREGA — Práctica 1: Pruebas Unitarias con MSTest y xUnit

**Estudiante:** Jason Vladymir Bautista Maravilla  
**Fecha:** 15 de octubre de 2026  
**Docente:** Gerber Alexis Gómez Hidalgo — ESFE ÁGAPE  

---

## ¿Qué debo entregar en Classroom?

### 1. Enlace al repositorio de GitHub
> ⏳ **Pendiente** — Necesito tu confirmación de visibilidad (público/privado) para publicar.
>
> Una vez publicado, el enlace quedará aquí:
> ```
> https://github.com/<tu-usuario>/Practica1-PruebasUnitarias
> ```

### 2. Enlace a Azure DevOps (Test Plans)
> ⏳ **Pendiente** — Necesito tu acceso a la organización de Azure DevOps para registrar los casos.
>
> Si no puedes registrarlos, entrega el archivo:
> ```
> Practica1-PruebasUnitarias/Documentacion_AzureDevOps.md
> ```

### 3. Capturas de pantalla
> 📁 Ubicación: `Practica1-PruebasUnitarias/Evidencias/`
>
> Las capturas deben mostrar la fecha y hora del sistema Windows.
> Ver instrucciones al final de este documento.

---

## Ruta local del proyecto

```
C:\Users\jason\Downloads\Practica1-PruebasUnitarias\
```

---

## Archivos clave que debes conocer

| Archivo | Descripción |
|---------|-------------|
| [JVBM.PruebasUnitarias.slnx](JVBM.PruebasUnitarias.slnx) | Solución .NET con los 4 proyectos |
| [README.md](README.md) | Documentación técnica completa |
| [Documentacion_AzureDevOps.md](Documentacion_AzureDevOps.md) | Todos los casos de prueba para Azure DevOps |
| [JVBM.Temperatura/TemperatureConverter.cs](JVBM.Temperatura/TemperatureConverter.cs) | Código del Ejercicio 1 |
| [JVBM.Temperatura.UnitTestMSTest/TemperatureConverterTests.cs](JVBM.Temperatura.UnitTestMSTest/TemperatureConverterTests.cs) | Pruebas MSTest |
| [JVBM.Cadenas/StringManipulator.cs](JVBM.Cadenas/StringManipulator.cs) | Código del Ejercicio 2 |
| [JVBM.Cadenas.UnitTestAppxUnit/StringManipulatorTests.cs](JVBM.Cadenas.UnitTestAppxUnit/StringManipulatorTests.cs) | Pruebas xUnit |

---

## Resultado de las pruebas (dotnet test)

```
MSTest  — JVBM.Temperatura.UnitTestMSTest:   24 pruebas, 24 correctas, 0 errores
xUnit   — JVBM.Cadenas.UnitTestAppxUnit:     18 pruebas, 18 correctas, 0 errores
TOTAL:                                        42 pruebas, 42 correctas, 0 errores
```

*(Actualizar con resultados exactos de la última ejecución)*

---

## Instrucciones para tomar capturas manuales

El docente exige que las capturas muestren **la fecha y hora del sistema**.

### Configuración recomendada
1. Asegúrate de que el **reloj de Windows** sea visible en la barra de tareas.
2. Abre una ventana de PowerShell o terminal.

### Capturas necesarias

| # | Qué capturar | Cómo hacerlo |
|---|-------------|--------------|
| 1 | **Estructura de la solución** | En VS Code o explorador de archivos, muestra los 4 proyectos |
| 2 | **Código TemperatureConverter.cs** | Abre el archivo en el editor |
| 3 | **Código TemperatureConverterTests.cs** | Abre el archivo en el editor |
| 4 | **Ejecución MSTest** | Ejecuta: `dotnet test JVBM.Temperatura.UnitTestMSTest\JVBM.Temperatura.UnitTestMSTest.csproj --verbosity normal` |
| 5 | **Código StringManipulator.cs** | Abre el archivo en el editor |
| 6 | **Código StringManipulatorTests.cs** | Abre el archivo en el editor |
| 7 | **Ejecución xUnit** | Ejecuta: `dotnet test JVBM.Cadenas.UnitTestAppxUnit\JVBM.Cadenas.UnitTestAppxUnit.csproj --verbosity normal` |
| 8 | **Resultado completo** | Ejecuta: `dotnet test JVBM.PruebasUnitarias.slnx --verbosity normal` |
| 9 | **Historial de commits** | Ejecuta: `git log --oneline` |
| 10 | **Repositorio en GitHub** | Captura el repositorio publicado en el navegador |

### Herramienta de captura
- Usa **Win + Shift + S** para capturar una región (Windows Snipping Tool)
- O usa **Win + PrtScn** para capturar toda la pantalla
- Guarda las capturas en: `C:\Users\jason\Downloads\Practica1-PruebasUnitarias\Evidencias\`

---

## Pasos pendientes que requieren tu intervención

### PASO 1: Publicar en GitHub
```powershell
# Desde la carpeta del proyecto:
cd C:\Users\jason\Downloads\Practica1-PruebasUnitarias

# Si tienes GitHub CLI instalado:
gh auth login
gh repo create Practica1-PruebasUnitarias --public --source=. --remote=origin --push

# O usando Git directamente (reemplaza TU_USUARIO con tu usuario de GitHub):
git remote add origin https://github.com/TU_USUARIO/Practica1-PruebasUnitarias.git
git branch -M main
git push -u origin main
```

### PASO 2: Registrar en Azure DevOps
1. Inicia sesión en https://dev.azure.com
2. Selecciona tu organización y proyecto
3. Ve a **Test Plans**
4. Crea un Test Plan llamado: `Práctica 1 - Pruebas Unitarias JVBM`
5. Copia los casos de prueba del archivo `Documentacion_AzureDevOps.md`

### PASO 3: Tomar las capturas de pantalla
- Sigue las instrucciones de la tabla anterior
- Guárdalas en la carpeta `Evidencias/`
- Asegúrate de que el reloj del sistema sea visible

---

## Comandos útiles

```powershell
# Ir a la carpeta del proyecto
cd C:\Users\jason\Downloads\Practica1-PruebasUnitarias

# Ver el historial de commits
git log --oneline

# Ejecutar todas las pruebas
dotnet test JVBM.PruebasUnitarias.slnx --verbosity normal

# Ejecutar solo MSTest
dotnet test JVBM.Temperatura.UnitTestMSTest\JVBM.Temperatura.UnitTestMSTest.csproj --verbosity normal

# Ejecutar solo xUnit
dotnet test JVBM.Cadenas.UnitTestAppxUnit\JVBM.Cadenas.UnitTestAppxUnit.csproj --verbosity normal
```

---

*Documento generado el 15 de octubre de 2026 — Práctica 1 ESFE ÁGAPE*
