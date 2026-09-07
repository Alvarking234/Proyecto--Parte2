#GoXela Delivery

Sistema de gestión de entregas desarrollado en C# como proyecto de aplicación para el curso de Programación Avanzada.

##Descripción

**GoXela Delivery** es una aplicación de consola orientada a la gestión de servicios de entrega. El sistema permite administrar clientes, repartidores, vehículos, paquetes, entregas e incidencias, aplicando principios de Programación Orientada a Objetos.

El proyecto fue desarrollado con el propósito de aplicar conceptos como encapsulamiento, herencia, polimorfismo, validaciones, manejo de excepciones, recursividad y estructuras de datos.

## Objetivo

Desarrollar un sistema que permita gestionar de manera organizada el proceso de registro, asignación, seguimiento y finalización de entregas.

## Funcionalidades

- Registro y consulta de clientes.
- Registro y consulta de repartidores.
- Registro y consulta de vehículos.
- Registro y consulta de paquetes.
- Registro y consulta de entregas.
- Cálculo automático de tarifas.
- Actualización del estado de las entregas.
- Registro y consulta de incidencias.
- Generación de reportes.
- Validación de datos y disponibilidad de recursos.
- Cancelación de entregas.
- Reprogramación de entregas.

## Tipos de paquetes

El sistema permite trabajar con diferentes tipos de paquetes:

- Documento
- Paquete estándar
- Paquete frágil
- Producto refrigerado

Cada tipo de paquete implementa su propio cálculo de tarifa mediante **polimorfismo**.

## Tipos de vehículos

El sistema contempla:

- Bicicleta
- Motocicleta
- Automóvil

Los vehículos utilizan herencia y métodos sobrescritos para determinar su capacidad de transporte.

## Cálculo de tarifas

La tarifa de una entrega considera diferentes factores:

- Tipo de paquete.
- Distancia recorrida.
- Tipo de servicio.
- Tipo de vehículo.
- Recargos correspondientes.

Los servicios disponibles son:

- **Normal**
- **Prioritario**
- **Urgente**


---

**GoXela Delivery — Sistema de gestión de entregas. 🚚**
