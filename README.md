# 🎓 MyHoursUAM

**Gestión eficiente de horas laborales y eventos para estudiantes becados.**

MyHoursUAM es una solución moderna y automatizada diseñada para los estudiantes de la **Universidad Americana (UAM)**.
Este sistema facilita el registro, la gestión y la validación de horas laborales y asistencia a eventos extracurriculares, ayudando a cumplir con los requisitos de beca y promoviendo una mayor participación estudiantil. 🎉

---

## 🚀 Características principales

- 📅 **Gestión de eventos y partidos**:
  - Visualización de todos los eventos disponibles.
  - Registro automático de asistencia.
  - Validación de cupos en tiempo real.

- ✅ **Seguimiento personalizado**:
  - Cada estudiante puede revisar los eventos asistidos.
  - Resumen de horas laborales completadas.

- 🔐 **Roles personalizados**:
  - Acceso diferenciado para estudiantes y administradores.
  - Administración de eventos, asistencia y reportes.

- 📊 **Generación de reportes**:
  - Reportes detallados para validar y auditar horas laborales.

- 🖥️ **Interfaz amigable**:
  - Diseño intuitivo para facilitar la interacción de estudiantes y personal administrativo.

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje**: C# (.NET Framework 4.7.2)
- **Interfaz gráfica**: Windows Forms
- **Arquitectura**: Modelo de objetos estructurado con separación de lógica y datos.

---

## 🏗️ Estructura del Proyecto (Detallada)

```plaintext
MyHoursUAM/
├── Administrador/           
│   ├── AdminAdd.cs           # Formulario para agregar nuevos administradores
│   ├── AdminAjustes.cs       # Configuración general del sistema
│   ├── AdminAsistencia.cs    # Gestión de asistencias de estudiantes
│   ├── AdminVer.cs           # Visualización de reportes y estadísticas
│   └── SplashScreenAdmin.cs  # Pantalla inicial del administrador
│
├── Estudiante/              
│   ├── UserEvento.cs         # Formulario para ver eventos disponibles
│   ├── UserAsistencia.cs     # Formulario para verificar asistencias del usuario
│   ├── UserMiPerfil.cs       # Configuración y detalles del perfil del estudiante
│   ├── UserReporte.cs        # Generación de reportes personalizados
│   └── SplashScreenUser.cs   # Pantalla inicial del estudiante
│
├── Estructuras/             
│   ├── Administrador.cs      # Clase modelo para datos del administrador
│   ├── Asistencia.cs         # Clase que gestiona las asistencias de estudiantes
│   ├── Estudiante.cs         # Clase modelo para datos del estudiante
│   ├── Evento.cs             # Clase que define eventos generales (base)
│   ├── Partido.cs            # Clase especializada en eventos deportivos
│   └── Metodos.cs            # Métodos auxiliares para lógica compartida
│
├── Forms/                   
│   ├── Sesion/              
│   │   ├── IniciarSesion.cs  # Formulario de inicio de sesión
│   │   ├── Rol.cs            # Selección de rol: estudiante o administrador
│   │   └── SplashScreen.cs   # Pantalla inicial para todos los usuarios
│   └── Administrador/Estudiante/  # Formularios organizados por rol
│
├── Properties/              
│   ├── AssemblyInfo.cs       # Información de ensamblado
│   ├── Resources.resx        # Recursos visuales del sistema
│   └── Settings.settings     # Configuración del entorno
│
└── Program.cs                # Punto de entrada principal
```

---

## 🌟 Cómo empezar

  1. **Clona este repositorio:**
     ```bash
     
     git clone https://github.com/tu-usuario/MyHoursUAM.git
     cd MyHoursUAM
     
  2. **Configura el entorno:**
     ```
     Requiere Visual Studio 2019 o superior.
     Asegúrate de tener instalado .NET Framework 4.7.2.
    
  4. **Ejecuta la solución:**
     ```
     Abre MyHours UAMApp.sln en Visual Studio.
    
     
  6. **¡Inicia el proyecto! 🎉**
     
---

##  👥 Colaboradores
Este proyecto fue desarrollado por estudiantes de la Universidad Americana (UAM) como parte del curso Análisis y Diseño de Sistemas y Metodología de la programación.

- Franco Xavier Aguilera Ortez - Desarrollador BackEnd
- Kristel Geraldine Villalta Porras - Desarrollador FrontEnd
- Steven Leonel Sequeira Reyes - Desarrollador
- David Joel Sánchez Acevedo - Lider del proyecto
- Andrea Johanna Duarte Guerrero - Desarrollador
- Carlos Alfredo Abea Martinez - QA 

---
## 📬 Contacto

Correo del lider: dsancheza@uamv.edu.ni
**Universidad Americana (UAM)**





   
