var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var html = @"
<!DOCTYPE html>
<html>
<head>
    <title>ASP.NET Core in Docker</title>
</head>
<body>
    <h1>ASP.NET Core in Docker</h1>
    <p>Running ASP.NET Core in Docker is easy!</p>
</body>";

app.MapGet("/", () => Results.Content(html, "text/html"));

app.Run();
