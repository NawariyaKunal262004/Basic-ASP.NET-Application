/*
 * ==============================================
 * ASP.NET Core Empty Web Application
 * ==============================================
 * 
 * A minimal API-based web application demonstrating basic HTTP routing
 * and HTTP method handling (GET, POST, PUT, DELETE).
 * 
 * ENDPOINTS:
 *   GET    /          - Root path
 *   GET    /Downloads - Downloads endpoint
 *   POST   /          - Post data to root
 *   PUT    /          - Update root resource
 *   DELETE /          - Delete root resource
 * 
 * FEATURES:
 *   - Simple route handlers using minimal APIs
 *   - Multiple HTTP methods on different endpoints
 *   - Quick request-response cycle with string responses
 * 
 * ==============================================
 */

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Root Path");
app.MapGet("/Downloads", () => "This is Downloads");
app.MapPut("/", () => "This is Put");
app.MapDelete("/", () => "Delete!!!!");
app.MapPost("/", () => "Post me");

app.Run();

/*
 * Simple minimal API application that demonstrates basic routing
 * and HTTP method handling. Each endpoint returns a simple string response.
 */
