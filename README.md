# ASP.NET Core Empty Web Application

## Project Overview

This is a **minimal ASP.NET Core web application** that demonstrates basic HTTP routing using the latest ASP.NET Core minimal APIs approach. It's a lightweight project designed to show how to set up a simple web application with various HTTP endpoints without the complexity of full-featured frameworks.

### Key Features
- ✅ Simple web application setup with ASP.NET Core
- ✅ Minimal API endpoints implementation
- ✅ Multiple HTTP methods support (GET, POST, PUT, DELETE)
- ✅ Basic request-response handling
- ✅ Easy to understand and extend

---

## Project Structure

```
AspNetCoreEmptyWeb/
├── Program.cs                      # Main application file with route handlers
├── AspNetCoreEmptyWeb.csproj       # Project file with framework and compiler settings
├── appsettings.json                # Application configuration settings
├── appsettings.Development.json    # Development-specific configuration
├── request.http                    # REST client file for testing endpoints
├── Properties/
│   └── launchSettings.json         # Development server launch configurations
├── obj/                            # Build artifacts (auto-generated)
└── bin/                            # Compiled binaries (auto-generated)
```

---

## Technical Details

### Framework & Version
- **Target Framework:** .NET 10.0
- **Language Features:** 
  - Nullable reference types enabled
  - Implicit using statements enabled
- **SDK:** Microsoft.NET.Sdk.Web

### Endpoints Defined

This application provides the following HTTP endpoints:

| HTTP Method | Endpoint | Response | Purpose |
|------------|----------|----------|---------|
| GET | `/` | "Root Path" | Main/root endpoint |
| GET | `/Downloads` | "This is Downloads" | Downloads endpoint |
| POST | `/` | "Post me" | Create/submit data |
| PUT | `/` | "This is Put" | Update existing resource |
| DELETE | `/` | "Delete!!!!" | Delete a resource |

---

## How to Run

### Prerequisites
- .NET 10.0 SDK or higher installed
- A terminal or command prompt
- Optional: REST client (Postman, Thunder Client, or VS Code REST Client extension)

### Steps to Run

1. **Navigate to the project directory:**
   ```bash
   cd c:\dotnet tut\AspNetCoreEmptyWeb
   ```

2. **Build the project (optional):**
   ```bash
   dotnet build
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

4. **Output Example:**
   ```
   info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5181
   ```

5. **The application will be accessible at:**
   - `http://localhost:5057` (if using the configured port)
   - Check `Properties/launchSettings.json` for the exact port

---

## Testing the Endpoints

### Using REST Client File (request.http)

The project includes a `request.http` file with predefined HTTP requests. You can test these using:
- **VS Code HTTP Client Extension**
- **JetBrains HTTP Client**
- **Other REST client tools**

Example requests in `request.http`:
```
GET http://localhost:5057

###

GET http://localhost:5057/Downloads

###

PUT http://localhost:5057

###

DELETE http://localhost:5057

###

POST http://localhost:5057
```

### Using cURL (Command Line)

```bash
# GET root endpoint
curl http://localhost:5057

# GET Downloads endpoint
curl http://localhost:5057/Downloads

# POST request
curl -X POST http://localhost:5057

# PUT request
curl -X PUT http://localhost:5057

# DELETE request
curl -X DELETE http://localhost:5057
```

### Using Postman

1. Create new GET request: `http://localhost:5057`
2. Create new GET request: `http://localhost:5057/Downloads`
3. Create new POST request: `http://localhost:5057`
4. Create new PUT request: `http://localhost:5057`
5. Create new DELETE request: `http://localhost:5057`

---

## Configuration

### appSettings.json
Contains application configuration settings for all environments:
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

**Explanation:**
- **Logging Configuration:** Sets log level to Information by default, but Windows Azure and other default Microsoft components log at Warning level
- **AllowedHosts:** Allows all hosts to access the application (use "*")

### appSettings.Development.json
Development-specific overrides (created for local development when needed)

### launchSettings.json
Defines how the application launches during development:
- Port configuration
- Environment variables
- HTTPS settings

---

## Code Explanation

### Program.cs Overview

The entire application is defined in `Program.cs` using a simplified minimal API approach:

1. **Builder Creation:** `WebApplication.CreateBuilder(args)` - Sets up the application host with default configuration

2. **App Build:** `builder.Build()` - Finalizes the configuration and creates the application instance

3. **Route Mapping:** `app.MapGet()`, `app.MapPost()`, etc. - Defines HTTP endpoint handlers

4. **Running:** `app.Run()` - Starts the HTTP server and listens for requests

### HTTP Methods Explained

- **GET:** Retrieves data (safe, idempotent)
- **POST:** Submits data to create a new resource (not idempotent)
- **PUT:** Updates an existing resource (idempotent)
- **DELETE:** Removes a resource (idempotent)

---

## Learning Path

This project is ideal for understanding:
1. ✅ ASP.NET Core application initialization
2. ✅ Minimal API pattern
3. ✅ HTTP routing fundamentals
4. ✅ HTTP method handling (GET, POST, PUT, DELETE)
5. ✅ Request-response cycle in web applications
6. ✅ Project structure and configuration

---

## Next Steps for Enhancement

To expand this project, consider:
1. **Add Parameters:** Accept query/route parameters in endpoints
2. **Add Models:** Create data models and return JSON
3. **Add Middleware:** Implement logging, error handling, authentication
4. **Add Dependency Injection:** Register services in the DI container
5. **Add Validation:** Validate incoming request data
6. **Add Database:** Connect to a database using Entity Framework Core

---

## Troubleshooting

| Issue | Solution |
|-------|----------|
| Port already in use | Change the port in `launchSettings.json` |
| Application won't start | Ensure .NET 10.0 SDK is installed: `dotnet --version` |
| Can't access endpoints | Verify the server is running and use correct localhost port |
| HTTPS connection errors | Use http://localhost (not https://) for local testing |

---

## Additional Resources

- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [Minimal APIs in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/)
- [HTTP Methods Reference](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods)
- [.NET CLI Commands](https://learn.microsoft.com/en-us/dotnet/core/tools/)

---

## License

This is a learning project demonstrating ASP.NET Core fundamentals.

---

**Created with ASP.NET Core Minimal APIs** | **.NET 10.0**
# Basic-ASP.NET-Application
