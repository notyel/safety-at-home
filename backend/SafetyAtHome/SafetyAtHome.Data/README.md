
# Instrucciones para ejecutar migraciones con Entity Framework Core

Estas instrucciones te guiar�n para ejecutar migraciones con Entity Framework Core en el proyecto "SafetyAtHome".

## Requisitos previos
- Tener .NET SDK instalado en tu m�quina.

## Pasos para ejecutar migraciones

1. Abre una terminal (cmd, PowerShell, o terminal de tu IDE).
2. Navega hasta la ra�z del proyecto "SafetyAtHome".

   ```bash
   cd safety-at-home\backend\SafetyAtHome
   ```

3. Ejecuta el siguiente comando para agregar una nueva migraci�n:

   ```bash
   dotnet ef migrations add InitialCreate --project SafetyAtHome.Data\SafetyAtHome.Data.csproj --startup-project SafetyAtHome.WebApi\SafetyAtHome.WebApi.csproj --output-dir Migrations
   ```

   Este comando agrega una nueva migraci�n llamada "InitialCreate" usando los proyectos `SafetyAtHome.Data` como el proyecto de datos y `SafetyAtHome.WebApi` como el proyecto de inicio de la API.

4. Una vez que la migraci�n se haya generado correctamente, puedes aplicarla a la base de datos ejecutando el siguiente comando:

   ```bash
   dotnet ef database update --project SafetyAtHome.Data\SafetyAtHome.Data.csproj --startup-project SafetyAtHome.WebApi\SafetyAtHome.WebApi.csproj
   ```

   Esto aplicar� la migraci�n a tu base de datos configurada.