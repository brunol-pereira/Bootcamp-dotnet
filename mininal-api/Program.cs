var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (loginDTO loginDTO)=>{
    if (loginDTO.Email == "a")
    {
        
    }
})


app.Run();

public class loginDTO
{
    public string Email {get; set;} = default!;
    public strind Senha { get; set; } = default!;
};