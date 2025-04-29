var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();

app.UseHttpsRedirection();

var listaCidades = new List<string> { "São Paulo", "Rio de Janeiro", "Belo Horizonte" };
var listaProdutos = new List<string> { "Produto 1", "Produto 2", "Produto 3" };

// PRIMEIRO ENDPOINT
app.MapGet("/", () => "Minha primeira apicação em C#!");
// SEGUNDO ENDPOINT
app.MapGet("/sobre", () => "Conteudo sobre API!");
// TERCEIRO ENDPOINT    
app.MapGet("/produtos", () => "Lista de produtos!" + string.Join(", ", listaProdutos));
// QUARTO ENDPOINT
app.MapGet("cidades", () => "Lista de cidades! " + string.Join(", ", listaCidades));
// QUINTO ENDPOINT
app.MapGet("data", () => "Data atual: " + DateTime.Now);
// SEXTO ENDPOINT
app.MapGet("data-atual", () => "Data atual: " + DateTime.Now.ToString("dd/MM/yyyy"));

// SÉTIMO ENDPOINT
app.MapGet("hora", () => "Hora atual: " + DateTime.Now.ToString("HH:mm:ss"));

app.Run();
