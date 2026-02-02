//CHATgpt was used here to help with erros when attempting to run swagger server to test
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//Use this to force use of Swagger server link
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
//Must use this to run swagger link 
app.MapControllers();

app.Run();
