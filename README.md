<div align="center">

# SGES — Sistema Gestor de Eventos SENA

### Aplicación de gestión de eventos e inscripciones para el Centro para la Industria Petroquímica

![SQL Server](https://img.shields.io/badge/DB-SQL%20Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)
![T-SQL](https://img.shields.io/badge/Language-T--SQL-1f6feb?style=flat)
![Windows](https://img.shields.io/badge/Platform-Windows-0078D6?style=flat&logo=windows&logoColor=white)
![WinForms](https://img.shields.io/badge/GUI-Windows%20Forms-512BD4?style=flat&logo=.net&logoColor=white)
![CSharp](https://img.shields.io/badge/Language-C%23-239120?style=flat&logo=csharp&logoColor=white)
[![License](https://img.shields.io/badge/License-MIT-lightgrey.svg)](LICENSE)
![Status](https://img.shields.io/badge/Status-En%20desarrollo-success?style=flat)
![Last commit](https://img.shields.io/github/last-commit/Louis-Du/sistemaGestorEventosSenaSGES?style=flat)

[Descripción](#-descripción) •
[Características](#-características-clave) •
[Estructura](#-estructura-del-repositorio) •
[Estadisticas](#-estadisticas) •
[Colaboradores](#-colaboradores)

</div>

---

## 📖 Descripción

**SGES (Sistema Gestor de Eventos SENA)** es un proyecto orientado a la **gestión de eventos académicos, culturales y deportivos** del **Centro para la Industria Petroquímica**.

El sistema contempla:

- Administración completa de eventos (creación, actualización, consulta, eliminación y programación).
- Inscripción de aprendices a eventos con validaciones.
- Generación de reportes para control y seguimiento de inscritos.

---

## 🚀 Características clave

### Roles
- **Administrador**
  - Crear eventos (académicos, culturales o deportivos).
  - Actualizar información de eventos.
  - Consultar eventos.
  - Programar fechas/ventanas de inscripción.
  - Eliminar eventos.
  - Gestionar información general del sistema.

- **Aprendiz**
  - Consultar eventos disponibles.
  - Inscribirse a eventos.

---

## 🗃️ Base de datos

El repositorio incluye el esquema de base de datos en:

- ![🗄️ Base de datos](https://github.com/Louis-Du/sistemaGestorEventosSenaSGES/blob/main/baseDatos)

Y documentación del modelo en:

- ![📄 Documents](https://github.com/Louis-Du/sistemaGestorEventosSenaSGES/tree/main/documents)

### Cómo preparar la BD (SQL Server)

1. Abrir **SQL Server Management Studio (SSMS)**.
2. Crear/seleccionar una base de datos.
3. Ejecutar el script:

```sql
-- Archivo: baseDatos/Schema.sql
```

> Si al integrar la app WinForms se agregan credenciales/cadena de conexión, se recomienda usar un archivo de configuración y/o variables de entorno, evitando subir datos sensibles al repositorio.

---

## 📁 Estructura del repositorio

```text
.
├─ README.md
├─ baseDatos/
│  └─ Schema.sql
└─ documents/
   └─ EntidadRelacion.png
```

---

## 📊 Estadisticas
![Alt](https://repobeats.axiom.co/api/embed/01770eb575770977131e8b838e9d8a36ff224518.svg "Repobeats analytics image")
---

## 👥 Colaboradores
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/eljavi0">
        <img src="https://github.com/eljavi0.png" width="100" style="border-radius: 50%" /><br />
        <sub><b>eljavi0</b></sub>
      </a><br />
      <sub>Desarrollador</sub>
    </td>
    <td align="center">
      <a href="https://github.com/Louis-Du">
        <img src="https://github.com/Louis-Du.png" width="100" style="border-radius:50%" /><br />
        <sub><b>Louis-Du</b></sub>
      </a><br />
      <sub>Desarrollador</sub>
    </td>
    <td align="center">
      <a href="https://github.com/lukasa133">
        <img src="https://github.com/lukasa133.png" width="100" style="border-radius:50%" /><br />
        <sub><b>lukasa133</b></sub>
      </a><br />
      <sub>Desarrollador</sub>
    </td>
  </tr>
</table>
