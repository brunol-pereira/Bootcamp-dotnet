using mininal_api.Dominio.DTO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "a")
    {

    }
});

app.Run();