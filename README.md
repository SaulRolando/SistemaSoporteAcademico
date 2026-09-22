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