# Portafolio Web Personal - ASP.NET Core MVC

Aplicación web desarrollada como proyecto académico para la carrera de **Ingeniería en Sistemas de la Información** en la **Universidad de Sonora (UNISON)**. 

El objetivo principal de este proyecto es aplicar el patrón de arquitectura **Modelo-Vista-Controlador (MVC)** en el ecosistema .NET para presentar mi perfil profesional, habilidades técnicas, proyectos de software, eventos tecnológicos y certificaciones.

---

## 🛠️ Tecnologías Utilizadas

* **Backend:** C# (.NET 8 / ASP.NET Core MVC)
* **Frontend:** Razor Views (`.cshtml`), HTML5, CSS3 personalizado, Bootstrap 5 e iconos de Bootstrap Icons.
* **Arquitectura y Buenas Prácticas:** Patrón MVC, uso de ViewModels (`HomeIndexViewModel`), Vistas Parciales (`_Presentacion`, `_Habilidades`) e inyección de datos estructurados.
* **Herramientas de Desarrollo:** Visual Studio 2022, Git y GitHub.

---

## 📋 Características del Portafolio

* **Presentación Profesional:** Información académica, perfil Full Stack, enlaces directos de contacto (Correo, LinkedIn, GitHub) y descarga directa de CV en formato PDF.
* **Sección de Habilidades:** Desglose estructurado del stack tecnológico dividido en desarrollo Back-end y Front-end.
* **Proyectos Recientes:** Catálogo dinámico de aplicaciones desarrolladas con enlaces a sus repositorios en GitHub.
* **Eventos y Participaciones:** Registro de hackathons y eventos tecnológicos (como el *Smart City Hackathon*).
* **Certificados y Cursos:** Muestra visual de certificaciones obtenidas en tecnologías como ASP.NET Core, Python y SQL Server.

---

## 📁 Estructura del Proyecto

```text
Portafolio/
├── Controllers/
│   └── HomeController.cs       # Lógica principal y carga de listas de datos
├── Models/
│   ├── Certificado.cs          # Modelo para certificaciones
│   ├── Evento.cs               # Modelo para eventos y hackathons
│   ├── HomeIndexViewModel.cs   # ViewModel principal de la vista Index
│   └── Proyecto.cs             # Modelo para proyectos de software
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml        # Vista principal
│   │   ├── _Habilidades.cshtml # Vista parcial de stack técnico
│   │   └── _Presentacion.cshtml# Vista parcial de bienvenida y contacto
│   └── Shared/
│       └── _Layout.cshtml      # Plantilla maestra
└── wwwroot/
    ├── css/                    # Estilos personalizados (custom.css)
    ├── documentos/             # Archivo PDF del Currículum Vitae
    └── imagenes/               # Recursos gráficos del portafolio
