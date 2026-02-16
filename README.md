# CleanArchitectureIngenieria-master

## 1. ¿Qué hace el patrón Repository en este proyecto?

El patrón **Repository** actúa como una capa de abstracción entre la lógica de negocio y la capa de acceso a datos. En este proyecto, cumple las siguientes funciones:

- **Abstrae el acceso a datos**: Encapsula toda la lógica de persistencia, permitiendo que la capa de aplicación no dependa directamente de Entity Framework Core o cualquier tecnología de base de datos específica.
- **Centraliza las operaciones CRUD**: Proporciona un conjunto común de operaciones (Create, Read, Update, Delete) para todas las entidades a través de `RepositoryBase<T>`.
- **Facilita el testing**: Al trabajar con interfaces, es más sencillo crear mocks y realizar pruebas unitarias sin necesidad de una base de datos real.
- **Mejora el mantenimiento**: Si en el futuro se decide cambiar el ORM o la tecnología de base de datos, solo se modificarían las implementaciones de los repositorios, no la lógica de negocio.

## 2. ¿Qué archivos creaste/modificaste para implementarlo?

### Archivos Creados

**Interfaces en la capa Application**:
- `IExistenciaRepository.cs`
- `IUnidadMedidaRepository.cs`
- `IMovimientoInventarioRepository.cs`
- `IProductoRepository.cs`
- `IProveedorRepository.cs`

**Implementaciones en la capa Infrastructure**:
- `ExistenciaRepository.cs`
- `UnidadMedidaRepository.cs`
- `MovimientoInventarioRepository.cs`
- `ProductoRepository.cs`
- `ProveedorRepository.cs`

### Archivos Modificados

- `CleanArchitecture.Infrastructure\ConfigurationServices.cs`: Se agregó el registro de los nuevos repositorios en el contenedor de inyección de dependencias.

## 3. ¿Cómo se conecta tu Repository con la capa de infraestructura y la capa de aplicación?

La conexión sigue los principios de **Clean Architecture** y **Dependency Inversion**:

### Flujo de Conexión:

┌─────────────────────────────────────────────────────────────┐ │  CAPA DE APLICACIÓN (Application Layer)                     │ │  ┌────────────────────────────────────────────────────┐    │ │  │  Interfaces (Contratos)                            │    │ │  │  - IExistenciaRepository                           │    │ │  │  - IProductoRepository                             │    │ │  │  - IRepositoryBase<T>                              │    │ │  └────────────────────────────────────────────────────┘    │ └─────────────────────────────────────────────────────────────┘ ▲ │ (depende de la abstracción) │ ┌─────────────────────────────────────────────────────────────┐ │  CAPA DE INFRAESTRUCTURA (Infrastructure Layer)             │ │  ┌────────────────────────────────────────────────────┐    │ │  │  Implementaciones Concretas                        │    │ │  │  - ExistenciaRepository : IExistenciaRepository    │    │ │  │  - ProductoRepository : IProductoRepository        │    │ │  │  - RepositoryBase<T> : IRepositoryBase<T>          │    │ │  └────────────────────────────────────────────────────┘    │ │                            ▲                                │ │                            │                                │ │  ┌────────────────────────────────────────────────────┐    │ │  │  ApplicationDbContext (Entity Framework Core)      │    │ │  └────────────────────────────────────────────────────┘    │ └─────────────────────────────────────────────────────────────┘  


### Pasos de la conexión:

1. **Definición de interfaces**: Las interfaces se definen en la capa de `Application` (ejemplo: `IProductoRepository`), estableciendo el contrato sin implementación.

2. **Implementación concreta**: La capa de `Infrastructure` implementa estas interfaces (ejemplo: `ProductoRepository`), heredando de `RepositoryBase<T>` que contiene la lógica común de acceso a datos.

3. **Inyección de dependencias**: En `ConfigurationServices.cs`, se registran los servicios: services.AddScoped<IProductoRepository, ProductoRepository>();

4. **Uso en servicios**: Los servicios de aplicación o controladores reciben las interfaces por inyección de dependencias, sin conocer la implementación concreta.

### Ventajas de esta arquitectura:
- La capa de Application **NO depende** de Infrastructure.
- Infrastructure **SÍ depende** de Application (solo de las interfaces).
- Se respeta el **Principio de Inversión de Dependencias**.

## 4. ¿Qué dificultades tuviste y cómo las resolviste?

### Dificultad 1: Identificar todas las entidades sin repositorio
**Solución**: Analicé sistemáticamente la carpeta `Domain\Entities` para identificar todas las entidades (Existencia, UnidadMedida, MovimientoInventario, Producto, Proveedor) y comparé con los repositorios existentes (Almacen, Categoria).

### Dificultad 2: Mantener la consistencia del patrón
**Solución**: Estudié los repositorios existentes (AlmacenRepository, CategoriaRepository) para replicar exactamente la misma estructura y nomenclatura, asegurando coherencia en todo el proyecto.

### Dificultad 3: Registro en el contenedor DI
**Solución**: Identifiqué el archivo `ConfigurationServices.cs` donde se registran las dependencias y agregué todos los nuevos repositorios siguiendo el mismo patrón `AddScoped`.

### Dificultad 4: Validación de la implementación
**Solución**: Ejecuté una compilación completa del proyecto para verificar que no hubiera errores de sintaxis, referencias faltantes o problemas de compatibilidad con .NET 10.
