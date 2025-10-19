# 🏗️ PROYECTO 1: COLA BÁSICA# 🏦 Sistema de Gestión de Cola Bancaria



Implementación web interactiva de los principales métodos de una estructura de datos **Cola (Queue)**, desarrollada con **ASP.NET Core 9.0** y **Razor Pages**.Sistema web interactivo para gestionar colas de atención en un banco, desarrollado con **ASP.NET Core 9.0** y **Razor Pages**.



## 🎯 Objetivo## 🎯 Características



Demostrar el funcionamiento de los métodos fundamentales de una estructura de datos **Cola** mediante una interfaz web visual e interactiva.### ✨ Funcionalidades CRUD Completas

- **Crear** tickets de atención con información del cliente

## ✨ Métodos Implementados- **Leer** y visualizar tickets organizados por estado

- **Actualizar** información de tickets en espera

### 📥 Métodos de Inserción y Eliminación- **Eliminar** tickets individuales o limpiar completados

- **Encolar (Enqueue)**: Agrega un elemento al final de la cola

- **Desencolar (Dequeue)**: Elimina y retorna el primer elemento de la cola (FIFO)### 🚀 Sistema de Prioridades

- **Normal** (⚪): Atención en orden FIFO estándar

### 🔍 Métodos de Consulta- **Preferente** (⭐): Botón de atención directa

- **Peek (Frente)**: Consulta el primer elemento sin eliminarlo- **Urgente** (🚨): Botón de atención inmediata

- **Peek Final**: Consulta el último elemento sin eliminarlo

- **¿Está Vacía?**: Verifica si la cola no tiene elementos### 📊 Panel de Control

- **¿Está Llena?**: Verifica si la cola alcanzó su capacidad máxima (10 elementos)- Estadísticas en tiempo real

- **Tamaño**: Retorna el número actual de elementos en la cola- Dashboard con contadores dinámicos

- Auto-actualización cada 5 segundos

### 🧹 Métodos de Gestión- Notificaciones de acciones

- **Mostrar**: Muestra todos los elementos actuales de la cola

- **Limpiar**: Elimina todos los elementos de la cola### 🎨 Interfaz de Usuario

- Diseño moderno con gradientes

## 🔄 Principio FIFO- Totalmente responsive

- Animaciones suaves

La cola sigue el principio **FIFO (First In, First Out)**:- Sistema de pestañas (En Espera, Atendiendo, Completados, Todos)

- El **primer** elemento que entra es el **primer** elemento que sale

- Ejemplo:## 🛠️ Tecnologías Utilizadas

  1. Encolar: 5, 10, 15 → Cola: [5, 10, 15]

  2. Desencolar → Saca el **5** → Cola: [10, 15]- **Backend**: ASP.NET Core 9.0

  3. Desencolar → Saca el **10** → Cola: [15]- **Frontend**: Razor Pages, HTML5, CSS3, JavaScript (ES6+)

- **Arquitectura**: MVC Pattern

## 🛠️ Tecnologías Utilizadas- **API**: RESTful API

- **Gestión de Estado**: Singleton Service Pattern

- **Backend**: ASP.NET Core 9.0

- **Frontend**: Razor Pages, HTML5, CSS3## 📋 Tipos de Operaciones

- **Estructura de Datos**: Queue<int> (Cola de enteros)

- **Capacidad Máxima**: 10 elementos1. Depósito

2. Retiro

## 🚀 Instalación y Ejecución3. Consulta

4. Apertura de Cuenta

### Requisitos Previos5. Pago de Servicios

- .NET 9.0 SDK6. Solicitud de Crédito

- Navegador web moderno7. Transferencia

8. **Robo** (Atención prioritaria)

### Pasos de Instalación

## 🚀 Instalación y Ejecución

1. **Clonar el repositorio**

```bash### Requisitos Previos

git clone https://github.com/Dark14411/Banco-c-.git- .NET 9.0 SDK

cd Banco-c-- Navegador web moderno

```

### Pasos de Instalación

2. **Restaurar dependencias**

```bash1. **Clonar el repositorio**

dotnet restore```bash

```git clone https://github.com/Dark14411/Banco-c-.git

cd Banco-c-

3. **Compilar el proyecto**```

```bash

dotnet build2. **Restaurar dependencias**

``````bash

dotnet restore

4. **Ejecutar la aplicación**```

```bash

dotnet run3. **Compilar el proyecto**

``````bash

dotnet build

5. **Abrir en el navegador**```

```

http://localhost:51324. **Ejecutar la aplicación**

``````bash

dotnet run

## 📁 Estructura del Proyecto```



```5. **Abrir en el navegador**

BancoWebApp/```

├── Pages/http://localhost:5132

│   ├── Index.cshtml           # Interfaz visual de la cola```

│   └── Index.cshtml.cs        # Lógica de los métodos de cola

└── Program.cs                 # Configuración de la aplicación## 📁 Estructura del Proyecto

```

```

## 💡 Uso de la AplicaciónBancoWebApp/

├── Controllers/

### 1. Encolar Elementos│   └── BancoController.cs       # API REST endpoints

- Ingresa un número en el campo de texto├── Models/

- Click en "➕ Encolar (Enqueue)"│   ├── Ticket.cs                # Modelo de datos del ticket

- El elemento se agrega al **final** de la cola│   └── Estadisticas.cs          # Modelo de estadísticas

├── Services/

### 2. Desencolar Elementos│   └── BancoQueueService.cs     # Lógica de gestión de cola

- Click en "➖ Desencolar (Dequeue)"├── Pages/

- Se elimina y muestra el **primer** elemento de la cola│   └── Index.cshtml             # Interfaz de usuario

- **Nota**: No necesitas ingresar ningún número, siempre saca el primero└── Program.cs                   # Configuración de la aplicación

```

### 3. Consultar la Cola

- **Peek (Frente)**: Ver el primer elemento sin eliminarlo## 🔌 API Endpoints

- **Peek Final**: Ver el último elemento sin eliminarlo

- **Mostrar**: Ver todos los elementos actuales en la cola### Tickets

- `GET /api/banco/tickets` - Obtener todos los tickets

### 4. Verificar Estado- `GET /api/banco/tickets/{id}` - Obtener ticket por ID

- **¿Está Vacía?**: Verifica si la cola tiene 0 elementos- `POST /api/banco/tickets` - Crear nuevo ticket

- **¿Está Llena?**: Verifica si la cola tiene 10 elementos (capacidad máxima)- `PUT /api/banco/tickets/{id}` - Actualizar ticket

- **Tamaño**: Muestra cuántos elementos hay actualmente- `DELETE /api/banco/tickets/{id}` - Eliminar ticket



### 5. Limpiar Cola### Estados

- Click en "🧹 Limpiar"- `GET /api/banco/espera` - Tickets en espera

- Elimina todos los elementos de la cola- `GET /api/banco/atendiendo` - Tickets en atención

- `GET /api/banco/completados` - Tickets completados

## 🎨 Características Visuales

### Acciones

- **Representación visual**: Los elementos se muestran como cajas con flechas- `POST /api/banco/atender` - Atender siguiente en cola

- **Panel de estado**: Muestra información en tiempo real- `POST /api/banco/atender/{id}` - Atender ticket específico (prioritario)

  - Tamaño actual- `POST /api/banco/completar/{id}` - Completar ticket

  - Estado (Vacía / Activa / Llena)- `DELETE /api/banco/limpiar-completados` - Limpiar completados

  - Elementos actuales

- **Mensajes de resultado**: Cada operación muestra un mensaje claro con emojis### Utilidades

- **Diseño responsive**: Se adapta a diferentes tamaños de pantalla- `GET /api/banco/estadisticas` - Obtener estadísticas

- **Gradiente moderno**: Interfaz atractiva con colores púrpura- `POST /api/banco/datos-prueba` - Cargar datos de prueba



## 🎓 Conceptos de Estructuras de Datos## 💡 Uso



### Cola (Queue)### Crear un Ticket

Una **cola** es una estructura de datos lineal que sigue el principio **FIFO**:1. Ingresa el nombre del cliente

2. Selecciona el tipo de operación

**Características**:3. Asigna la prioridad

- Los elementos se insertan por un extremo (final)4. Click en "Generar Ticket"

- Los elementos se eliminan por el otro extremo (frente)

- No se puede acceder a elementos intermedios directamente### Atender Clientes

- Capacidad limitada (10 elementos en este proyecto)- **Orden normal**: Click en "▶️ Atender Siguiente"

- **Atención prioritaria**: Click en "▶️ Atender" (solo en tickets Preferentes/Urgentes)

**Aplicaciones reales**:

- Colas de impresión### Gestionar Tickets

- Gestión de procesos en sistemas operativos- **Editar**: Click en "✏️ Editar" (solo en espera)

- Colas de atención en bancos, hospitales, etc.- **Eliminar**: Click en "🗑️ Eliminar" (solo en espera)

- Buffer de datos en comunicaciones- **Completar**: Click en "✅ Completar" (solo en atención)



## 🤝 Contribuciones## 🎓 Conceptos de Estructuras de Datos



Las contribuciones son bienvenidas. Por favor:Este proyecto implementa los siguientes conceptos:



1. Fork el proyecto- **Cola (Queue)**: FIFO para gestión de tickets en espera

2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)- **Lista (List)**: Para tickets en atención y completados

3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)- **Diccionario (Dictionary)**: Para acceso rápido por ID

4. Push a la rama (`git push origin feature/AmazingFeature`)- **Singleton Pattern**: Para mantener estado global

5. Abre un Pull Request- **Thread Safety**: Lock para operaciones concurrentes



## 📝 Licencia## 🤝 Contribuciones



Este proyecto es de código abierto y está disponible bajo la licencia MIT.Las contribuciones son bienvenidas. Por favor:



## 👨‍💻 Autor1. Fork el proyecto

2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)

**Dark14411**3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)

- GitHub: [@Dark14411](https://github.com/Dark14411)4. Push a la rama (`git push origin feature/AmazingFeature`)

5. Abre un Pull Request

## 🙏 Agradecimientos

## 📝 Licencia

- Proyecto educativo para demostrar el funcionamiento de estructuras de datos tipo Cola

- Diseño UI moderno con gradientes y animacionesEste proyecto es de código abierto y está disponible bajo la licencia MIT.

- Implementación basada en buenas prácticas de ASP.NET Core

## 👨‍💻 Autor

---

**Dark14411**

⭐ Si te gusta este proyecto, dale una estrella en GitHub!- GitHub: [@Dark14411](https://github.com/Dark14411)


## 🙏 Agradecimientos

- Proyecto desarrollado como ejemplo de implementación de estructuras de datos (Colas)
- Diseño UI inspirado en principios de Material Design
- Patrones de arquitectura basados en buenas prácticas de ASP.NET Core

---

⭐ Si te gusta este proyecto, dale una estrella en GitHub!

## Nota sobre concurrencia

La implementación interna de la cola usa una instancia estática de `Queue<int>` en memoria. Para evitar condiciones de carrera cuando varias solicitudes acceden simultáneamente a la cola, se ha añadido una protección sencilla mediante un `lock` (campo `colaLock`) que serializa las operaciones críticas: Enqueue, Dequeue, Invertir y Limpiar.

Esto mantiene el comportamiento FIFO esperado y evita que la cola supere la capacidad o se corrompa en escenarios concurrentes. Para producción se puede considerar usar `ConcurrentQueue<T>` con mecanismos adicionales de control de capacidad, o persistir el estado en una base de datos.

