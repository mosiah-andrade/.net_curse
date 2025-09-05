// Importa o namespace do FluentValidation (corrija o nome se necessário)
using FlutentValidation;

// Cria o builder para configurar a aplicação web
var builder = WebApplication.CreateBuilder(args);

// Adiciona todos os validadores do assembly atual aos serviços da aplicação
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

// Constrói a aplicação web
var app = builder.Build();