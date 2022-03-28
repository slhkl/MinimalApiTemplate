using Business;
using Data.Dtos;
using Data.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/GetAllBooks", () =>
{
    return BookBusiness.GetAll();
});

app.MapGet("/GetBookById/{id}", (int id) =>
{
    return BookBusiness.GetById(id);
});

app.MapPost("/AddBook", (BookDTO book) =>
{
    return BookBusiness.Add(book);
});

app.MapDelete("/RemoveBook/{id}", (int id) =>
{
    return BookBusiness.Remove(id);
});
app.MapGet("/GetAllWriters", () =>
{
    return WriterBusiness.GetAll();
});

app.MapGet("/GetWriterById/{id}", (int id) =>
{
    return WriterBusiness.GetById(id);
});

app.MapPost("/AddWriter", (Writer writer) =>
{
    return WriterBusiness.Add(writer);
});

app.MapDelete("/RemoveWriter/{id}", (int id) =>
{
    return WriterBusiness.Remove(id);
});

app.Run();
