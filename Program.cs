//Brandon Le
//10-27-22
//Mini Challenge 10 - Magic 8 Ball
//Web API project that will generate random answers just like a magic 8 ball to "answer" the question that the user is thinking in their head or asking aloud. There are 8 different responses in total. If the user enters in something other than AMA at the end of the URL then there will be an error code to prompt them to fix it and it also provides the proper URL for them to click. There's also an instructions page at the very beginning with URL ending in /minich10/ that also provides a link for people to click if they don't understand. Simply have to press send to refresh a new answer.
//peer review: Samuel Laguna: The project ran good. The inputs work how they should. And the terminal spits out the corect info. It even tells you if the entry is invalid. This code is all good.


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
