// ============================================
// ASP.NET Core Empty Web Application
// A minimal API-based web application demonstrating basic HTTP routing
// ============================================

// Creates a WebApplicationBuilder which sets up the HTTP request pipeline
// This builder handles configuration, logging, dependency injection setup, and middleware configuration
var builder = WebApplication.CreateBuilder(args);

// Builds the WebApplication instance from the configured builder
// This creates the actual application ready to process HTTP requests
var app = builder.Build();

// ============================================
// ROUTE HANDLERS - Define HTTP endpoints
// ============================================

// GET / handler - Returns a simple response for root path requests
// When user navigates to http://localhost:port/, this handler executes
app.MapGet("/", () => "Root Path");

// GET /Downloads handler - Returns a response for the Downloads endpoint
// When user navigates to http://localhost:port/Downloads, this handler executes
app.MapGet("/Downloads", () => "This is Downloads");

// PUT / handler - Handles PUT requests to root path
// PUT is typically used to update existing resources
// When client sends PUT request to http://localhost:port/, this handler executes
app.MapPut("/", () => "This is Put");

// DELETE / handler - Handles DELETE requests to root path
// DELETE is used to remove resources
// When client sends DELETE request to http://localhost:port/, this handler executes
app.MapDelete("/", () => "Delete!!!!");

// POST / handler - Handles POST requests to root path
// POST is typically used to create new resources
// When client sends POST request to http://localhost:port/, this handler executes
app.MapPost("/", () => "Post me");


// Runs the application and listens for incoming HTTP requests
// This method blocks until the application is stopped (Ctrl+C or shutdown signal)
app.Run();
