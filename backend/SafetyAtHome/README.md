### Funci�n de Cada Capa

#### Api

- **Funci�n**: Manejar las solicitudes y respuestas HTTP.
- **Responsabilidad**: Convertir los datos de entrada en objetos de dominio y devolver los resultados como respuestas HTTP.

#### Business

- **Funci�n**: Implementar la l�gica de negocio de la aplicaci�n.
- **Responsabilidad**: Contener los servicios que coordinan el flujo de trabajo del dominio y aplican las reglas de negocio.

#### Data

- **Funci�n**: Gestionar la persistencia y recuperaci�n de datos.
- **Responsabilidad**: Interactuar con la base de datos **utilizando Entity Framework** o cualquier otra tecnolog�a de acceso a datos.

#### Domain

- **Funci�n**: Definir el modelo de dominio.
- **Responsabilidad**: Contener las entidades del dominio, los valores y las reglas de negocio fundamentales.

#### Common

- **Funci�n**: Proveer utilidades y modelos compartidos entre los proyectos.
- **Responsabilidad**: Facilitar la reutilizaci�n del c�digo entre las diferentes capas y proyectos.


Con esta estructura y nombre, seguimos las pr�cticas recomendadas de dise�o orientado al dominio, asegurando una separaci�n clara de responsabilidades y facilitando el mantenimiento y escalabilidad del proyecto.