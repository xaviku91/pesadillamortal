# Juego VR/AR - Grupo vrxperience

Este repositorio es utilizado para el desarrollo del videojuego creado por el grupo **_vrxperience_** en el proyecto de _(P)Diseño y programación de un videojuego en VR/AR_ de la **_[UOC](https://www.uoc.edu/portal/es/index.html)_** (Universitat Oberta de Catalunya).

## 1. INTEGRANTES DEL EQUIPO DE DESARROLLO:

- **Nombre:** Xavi Quesada Sevillano  
  **Correo:** [xquesadas@uoc.edu](mailto:xquesadas@uoc.edu )  
  **Github:** [xaviku91](https://github.com/xaviku91)

- **Nombre:** Josep de Trastàmara  
  **Correo:** [correo@ejemplo.com](mailto:correo@ejemplo.com)  
  **Github:** [usuario_github](https://github.com/usuario_github)
  
- **Nombre:** Jordi Hortigüela Estrada  
  **Correo:** [correo@ejemplo.com](mailto:correo@ejemplo.com)  
  **Github:** [usuario_github](https://github.com/usuario_github)

- **Nombre:** Robert Benavides Gómez  
  **Correo:** [rbenavidesgo@uoc.edu](mailto:rbenavidesgo@uoc.edu)  
  **Github:** [Warrio111](https://github.com/Warrio111)

- **Nombre:** Albert López  
  **Correo:** [correo@ejemplo.com](mailto:correo@ejemplo.com)  
  **Github:** [usuario_github](https://github.com/usuario_github)

- **Nombre:** Adrià Puigvert Avellaneda  
  **Correo:** [correo@ejemplo.com](mailto:correo@ejemplo.com)  
  **Github:** [usuario_github](https://github.com/usuario_github)


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

# XR Interaction Toolkit Examples - Version 2.3.2

## Introduction

This project provides examples that use Unity's [XR Interaction Toolkit](https://docs.unity3d.com/Manual/com.unity.xr.interaction.toolkit.html) (XRI) to demonstrate its functionality with example assets and behaviors.
The intention of this project is to provide a means for getting started with the features in the XR Interaction Toolkit package.

> Note: If you are looking for the original XRI Examples project, that has been archived into two separate branches [Classic 1.0](https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples/tree/1.0/classic) and [Classic 2.2](https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples/tree/classic/2.2). Both of these branches still have both the `AR` and `VR` projects available.

## Getting started

### Requirements
The current version of the XRI Examples is compatible with the following versions of the Unity Editor:

* 2020.3 and later

### Downloading the project

1. Clone or download this repository to a workspace on your drive
    1. Click the **⤓ Code** button on this page to get the URL to clone with Git or click **Download ZIP** to get a copy of this repository that you can extract
1. Open a project in Unity
    1. Download, install, and run [Unity Hub](https://unity3d.com/get-unity/download)
    1. In the **Installs** tab, select **Locate** or **Add** to find or install Unity 2020.3 LTS or later. Include the **Windows Build Support (IL2CPP)** module if building for PC, and the **Android Build Support** if building for Android (for example, Meta Quest).
    1. In the **Projects** tab, click **Add**
    1. Browse to folder where you downloaded a copy of this repository and click **Select Folder**
    1. Verify the project has been added as **XR-Interaction-Toolkit-Examples**, and click on it to open the project

## General setup

The main example scene is located at `Assets/XRI_Examples/Scenes/XRI_Examples_Main`. This example scene is laid out as a ring with different stations along it. The first examples you will encounter are the simplest use-cases of XRI features. Behind each example is a doorway leading to advanced uses of each feature.

Use the simple examples when you need objects you can copy-and-paste, while leveraging the advanced examples when needing to achieve complex outcomes.

The **XR Origin** is located within the **Complete Set Up** prefab. This prefab contains everything needed for a fully functional user interaction with XRI. This includes the components needed for general input, interaction, and UI interaction.

Scripts, assets, and prefabs related to each feature or use case are located in the associated folder in `Assets/XRI_Examples`.

The following stations are available in the XRI Examples:

* [Station 1: Locomotion Setup](Documentation/LocomotionSetup.md) - Overview of the built-in locomotion options and how to configure them.
* [Station 2: Grab Interactables](Documentation/GrabInteractables.md) - Basic object manipulation.
* [Station 3: Activate Interactables](Documentation/ActivateInteractables.md) - Manipulation of objects that can be triggered by the user.
* [Station 4: Socket Interactors](Documentation/SocketInteractors.md) - Manipulation of objects that can snap to specific positions.
* [Station 5: Gaze Interactions](Documentation/Gaze.md) - Leverage the eye-tracked or head-based gaze interactor to add assistive interaction to your projects.
* [Station 6: 2D UI](Documentation/UI-2D.md) - Creation and interaction with [world space](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UICanvas.html#world-space) 2D UI.
* [Station 7: 3D UI](Documentation/UI-3D.md) - Creation and interaction with 3D constrained controls.
* [Station 8: Physics Interactables](Documentation/PhysicsInteractables.md) - Best practices for combining physics and XR input.

For a list of new features and deprecations, see [XRI Examples Changelog](CHANGELOG.md).

For an overview of how the [Input System](https://docs.unity3d.com/Manual/com.unity.inputsystem.html) is used in this example, see [Input](Documentation/Input.md).

## Sharing feedback

The [XR Interaction Toolkit and Input forum](https://forum.unity.com/forums/xr-interaction-toolkit-and-input.519/) is the best place to open discussions and ask questions. Please use the [public roadmap](https://portal.productboard.com/brs5gbymuktquzeomnargn2u) to submit feature requests. If you encounter a bug, please use the Unity Bug Reporter in the Unity Editor, accessible via **Help &gt; Report a Bug**. Include “XR Interaction Toolkit” in the title to help our team triage things appropriately!

## Contributions and pull requests

We are not accepting pull requests at this time.

