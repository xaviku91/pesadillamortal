# Juego VR/AR - Grupo vrxperience

Este repositorio es utilizado para el desarrollo del videojuego creado por el grupo **_vrxperience_** en el proyecto de _(P)Diseño y programación de un videojuego en VR/AR_ de la **_[UOC](https://www.uoc.edu/portal/es/index.html)_** (Universitat Oberta de Catalunya).

## 1. INTEGRANTES DEL EQUIPO DE DESARROLLO:

- **Nombre:** Xavi Quesada Sevillano  
  **Correo:** [xquesadas@uoc.edu](mailto:xquesadas@uoc.edu )  
  **Github:** [xaviku91](https://github.com/xaviku91)

- **Nombre:** Josep de Trastàmara  
  **Correo:** [User](https://github.com/)
  **Github:** [User](https://github.com/)
  
- **Nombre:** Jordi Hortigüela Estrada  
  **Correo:** [jhortiguelae@uoc.edu](mailto:jhortiguelae@uoc.edu)  
  **Github:** [JordiHorti](https://github.com/JordiHorti)

- **Nombre:** Robert Benavides Gómez  
  **Correo:** [rbenavidesgo@uoc.edu](mailto:rbenavidesgo@uoc.edu)  
  **Github:** [Warrio111](https://github.com/Warrio111)

- **Nombre:** Albert López  
  **Correo:** [alopezpaj@uoc.edu](mailto:alopezpaj@uoc.edu)  
  **Github:** [Albertlp93](https://github.com/Albertlp93)

- **Nombre:** Adrià Puigvert Avellaneda  
  **Correo:** [apuigverta@uoc.edu](mailto:apuigverta@uoc.edu)
  **Github:** [Night2k](https://github.com/Night2k)


## **2. METODOLOGÍA Y SEGUIMIENTO:**

- **Metodología de Desarrollo:**

    El equipo _vrxperience_ sigue una metodología específica para el desarrollo del videojuego. Actualmente, estamos utilizando la metodología **[Scrum](https://proyectosagiles.org/que-es-scrum/)** para estructurar nuestras tareas y asegurar una colaboración efectiva.

- **Herramienta de Seguimiento:**

    Utilizamos Trello para organizar y hacer un seguimiento de nuestras tareas. Puedes seguir nuestro progreso y ver las tareas pendientes en nuestro tablero de Trello **[[aquí]](https://trello.com/invite/b/ImzhB75o/ATTI5ce7a8f6cb0ff644132b1aef1c86083f1292A07D/vrxperience)**.

- **Reuniones y Comunicación:**

    Mantenemos una comunicación regular a través de Telegram para discutir avances, resolver problemas y coordinar esfuerzos. Además, cualquier decisión importante se registra en la documentación de nuestro _Google Drive_.

- **Progreso Actual:**

    Puedes ver nuestro progreso actual y las próximas tareas planeadas en la sección de [Proyectos de GitHub](https://github.com/tu-usuario/tu-repositorio/projects).

________________________________________________________

## Flujo de Trabajo

### 1. Clonar el Repositorio

Primero, clona el repositorio desde la rama principal (Main) a tu máquina local.

``` bash
git clone https://github.com/xaviku91/pesadillamortal.git
cd pesadillamortal
```
### 2. Actualizar la Rama Main
Asegúrate de tener la última versión de la rama Main antes de empezar a trabajar en tu desarrollo.

```bash
git fetch origin
git checkout main
git pull origin main
```
### 3. Crear una Rama de Desarrollo
Para cualquier nuevo desarrollo en la aplicación, crea una nueva rama de desarrollo desde Main. Asegúrate de darle un nombre descriptivo, por ejemplo, dev/nueva-funcionalidad.

```bash

git checkout -b dev/nueva-funcionalidad
```
### 4. Trabajar en tu Desarrollo
Realiza tus cambios y desarrollos en esta nueva rama. Asegúrate de escribir pruebas unitarias asociadas y verificar que todo funcione correctamente.

### 5. Actualizar desde Main
Antes de finalizar tu desarrollo, asegúrate de estar al día con la rama Main.

```bash
git checkout main
git pull origin main
```
### 6. Hacer un Merge de Main a tu Rama de Desarrollo
Integra cualquier cambio nuevo de Main en tu rama de desarrollo antes de finalizar.

```bash

git checkout dev/nueva-funcionalidad
git merge main
```
Resuelve cualquier conflicto si es necesario.

### 7. Enviar una Solicitud de Extracción (Pull Request)
Cuando tu desarrollo esté completo y funcionando correctamente, sube tu rama de desarrollo a GitHub y crea una Solicitud de Extracción (Pull Request) hacia la rama Main. Asigna a algun companero para que valide tu integración.

### 8. Revisión y Aprobación
El revisor revisará tu código y, una vez aprobado, se fusionará con la rama Main.

# Contacto
Si tienes alguna pregunta o necesitas ayuda, no dudes en ponerte en contacto con el equipo de desarrollo.

Este flujo de trabajo te ayudará a mantener un proyecto ordenado y colaborativo, asegurando que todos los cambios se integren correctamente y que la rama Main siempre esté en buen estado.

________________________________________________________
