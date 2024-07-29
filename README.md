Sistema de Gestión de Seguros Supra
Este repositorio contiene el código fuente para un sistema de gestión de seguros basado en microservicios. La arquitectura del sistema está diseñada para gestionar diversos aspectos del proceso de seguros, desde la gestión de clientes hasta el procesamiento de reclamaciones y pagos, a través de una serie de microservicios y componentes de infraestructura.

Contenido del Repositorio
1. Controladores
Implementaciones para los servicios API, incluyendo ejemplos como Customer. Estos controladores manejan las solicitudes entrantes y responden con datos procesados por los microservicios.

2. Servicios y Repositorios
Servicios: Contienen la lógica de negocio y las interacciones con servicios externos. Cada servicio está basado en una interfaz que define las operaciones disponibles.
Repositorios: Gestionan el acceso a datos y la lógica de persistencia. Cada repositorio se encarga de interactuar con su base de datos específica para operaciones CRUD.
3. Componente de Autenticación
Gestiona la autenticación y autorización para los diferentes componentes del sistema, asegurando que solo usuarios y servicios autorizados puedan acceder a la información y funcionalidades.

4. API Gateway
Actúa como punto de entrada para todas las solicitudes a los microservicios. Se encarga del enrutamiento de solicitudes, manejo de autenticación y agregación de respuestas.

5. Microservicios
Gestión de Clientes: Maneja la información y operaciones relacionadas con los clientes.
Políticas: Gestiona las pólizas de seguros y sus detalles.
Reclamaciones: Procesa y gestiona las reclamaciones realizadas por los clientes.
Pagos: Gestiona los pagos realizados por los clientes y las transacciones asociadas.
Agentes: Administra la información y operaciones relacionadas con los agentes de seguros.
Siniestros: Gestiona los siniestros y los daños asociados a las pólizas.
Adquisición de Planes: Maneja la compra y adquisición de nuevos planes de seguros por parte de los clientes.
Instrucciones para la Ejecución
Actualizar Ruta de Base de Datos:

Después de clonar el repositorio, actualiza la cadena de conexión en el archivo de configuración appsettings.json.
Ejecutar Actualización de Base de Datos:

Abre la consola del Administrador de Paquetes de NuGet en cada proyecto que contenga un DbContext y ejecuta el comando:
"update-database" sin comillas
Esto aplicará las migraciones y creará las bases de datos necesarias.
Ejecutar la Aplicación:

Asegúrate de que todos los servicios y microservicios estén en ejecución para que el sistema funcione correctamente.
Ejemplo de Implementación
Customer Service: Implementación detallada del controlador para gestionar clientes, incluyendo la integración con el API Gateway y los microservicios asociados.
