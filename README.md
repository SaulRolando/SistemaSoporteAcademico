# Sistema de Orientación y Registro de Atenciones

## Caso práctico

Sistema de orientación y registro de atenciones para el módulo de soporte académico.

## Lenguaje utilizado

C#

## Tipo de aplicación

Aplicación de consola.

## Descripción

El sistema permite registrar solicitudes de estudiantes que necesitan
orientación sobre matrícula, pagos, constancias, plataformas académicas
u otros temas.

El programa valida los datos ingresados y asigna una prioridad de atención
según el tipo de consulta.

## Integrantes

- [Nombre del integrante 1] - [Código]
- [Nombre del integrante 2] - [Código]
- [Nombre del integrante 3] - [Código]
- [Nombre del integrante 4] - [Código]

## Requerimientos

El proyecto implementa los 12 requerimientos establecidos en la guía
de laboratorio, incluyendo:

- Registro de solicitudes.
- Validación de datos.
- Funciones con y sin retorno.
- Paso de parámetros.
- Control del alcance de variables.
- Encapsulamiento de reglas.
- Registro de múltiples solicitudes.
- Pruebas.
- Control de versiones con Git y GitHub.

## Pruebas realizadas

Se realizaron las siguientes pruebas al sistema:

1. **Prueba válida:** se registró correctamente una solicitud con datos válidos.
2. **Campo vacío:** el sistema rechazó un campo obligatorio vacío.
3. **Tipo incorrecto:** el sistema rechazó un tipo de consulta no permitido.
4. **Prioridad alta:** una consulta de tipo "pagos" obtuvo prioridad Alta.
5. **Prioridad baja:** una consulta de tipo "constancia" obtuvo prioridad Baja.

## Relación entre funciones y requisitos

| Función / elemento | Requisito | Descripción |
|---|---|---|
| `MostrarMenu()` | R4 | Muestra el menú principal del sistema. |
| `ValidarCodigo()` | R2 | Verifica que el código no esté vacío y tenga mínimo 6 caracteres. |
| `ValidarTipoConsulta()` | R3 | Comprueba que el tipo de consulta sea válido. |
| `CalcularPrioridad()` | R5 | Asigna prioridad Alta, Media o Baja según el tipo de consulta. |
| `ValidarTexto()` | R6 | Verifica que los campos de texto obligatorios no estén vacíos. |
| `MostrarResumen()` | R7 | Muestra los datos registrados de la solicitud. |
| Parámetros de las funciones | R8 | Permiten enviar los datos necesarios a cada función sin usar variables globales innecesarias. |
| Variables locales | R9 | Mantienen cada variable dentro del ámbito donde se necesita. |
| Lista `solicitudes` | R10 | Permite registrar y almacenar múltiples solicitudes durante una ejecución. |
| Pruebas realizadas | R11 | Comprueba el funcionamiento mediante cinco casos de prueba. |
| README.md | R12 | Documenta la relación entre los requisitos y las funciones del sistema. |