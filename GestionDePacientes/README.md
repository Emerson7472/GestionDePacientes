# Sistema de Gestión de Pacientes - UCE

## Integrantes

>>> Nombre Completo | Matrícula <<<
_________________________________________
>>>Emerson Ciriaco Ortiz (2026-1222)
>>>Nombre y matricula
>>>Nombre y matricula
>>>Nombre y matricula
>>>Nombre y matricula


**Asignatura:** Programación Básica  
**Profesor:** Gamalier Reyes del Carmen  
**Universidad:** Universidad Central del Este (UCE)


## Descripción Breve
Esta aplicación es un sistema de escritorio desarrollado en C# con interfaz gráfica Windows Forms (.NET). Permite gestionar la información de pacientes en un centro de salud mediante operaciones CRUD (Crear, Leer, Actualizar y Eliminar). Toda la información se administra en memoria utilizando listas dinámicas (`List<Paciente>`), aplicando conceptos de programación orientada a objetos (POO), manejo de excepciones personalizadas, enumeraciones y validaciones de datos de entrada.


## Datos de Entrada
La información es ingresada por el usuario a través de los siguientes controles de formulario:
* **ID / Cédula:** Identificador único (`TextBox`).
* **Nombre Completo:** Cadena de texto (`TextBox`).
* **Edad:** Valor numérico entero entre 0 y 120 (`TextBox`).
* **Sexo:** Selección predefinida basada en el `enum Sexo` (`ComboBox`: `Masculino`, `Femenino`).
* **Diagnóstico:** Descripción clínica del paciente (`TextBox`).
* **Estado del Paciente:** Selección predefinida basada en el `enum EstadoPaciente` (`ComboBox`: `Ingresado`, `EnObservacion`, `DeAlta`, `Hospitalizado`).
* **Fecha de Ingreso:** Selección de fecha (`DateTimePicker`).
* **Criterio de Búsqueda:** Campo de texto para filtrar por ID o Nombre (`TextBox`).


## Datos que Procesa
El sistema ejecuta la lógica de negocio mediante la clase gestora (`GestorPacientes`):
1. **Validaciones de Entrada:** Comprobación de campos obligatorios, conversión de datos numéricos y verificación de no duplicidad del ID.
2. **Manejo de Excepciones:** Tratamiento de errores mediante bloques `try-catch` y excepciones personalizadas (`PacienteNoEncontradoException`, `PacienteDuplicadoException`).
3. **Operaciones CRUD:**
    * **Crear:** Instanciación y adición de objetos `Paciente` en la lista dinámica `List<Paciente>`.
    * **Leer / Consultar:** Consultas y filtrado dinámico mediante expresiones LINQ.
    * **Actualizar:** Búsqueda en memoria y modificación de las propiedades del objeto seleccionado.
    * **Eliminar:** Remoción del objeto en la lista dinámica tras confirmación del usuario.

---

## Datos de Salida
* **DataGridView:** Muestra los registros almacenados o los resultados de las búsquedas en formato tabular.
* **MessageBox:**
    * Diálogos de información (`Information`) al completar registros, actualizaciones o eliminaciones.
    * Diálogos de confirmación (`Question`) con botones `Sí/No` para verificar eliminaciones y preguntar si el usuario desea realizar otra transacción.
    * Mensajes de advertencia o error (`Warning` / `Error`) en caso de excepciones o fallas de validación.

---

## Capturas de Pantalla

> *Nota: Guarda las capturas en una carpeta llamada `docs` dentro de tu repositorio para vincularlas aquí.*

### 1. Formulario Principal y Listado de Pacientes
![Listado General](docs/01_listado_general.png)

### 2. Registro de un Nuevo Paciente
![Registro de Paciente](docs/02_registro_paciente.png)

### 3. Búsqueda y Filtrado (por ID o Nombre)
![Búsqueda de Paciente](docs/03_busqueda_paciente.png)

### 4. Actualización de Datos
![Actualización de Paciente](docs/04_actualizacion_paciente.png)

### 5. Confirmación y Eliminación de Registro
![Eliminación de Paciente](docs/05_eliminacion_paciente.png)

### 6. Validaciones y Mensajes de Excepción
![Mensaje de Error](docs/06_validacion_error.png)