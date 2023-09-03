using GraphQL.Server;
using GraphQL.Types;
using GraphQLTestWebProject.Data;
using GraphQLTestWebProject.Interfaces;
using GraphQLTestWebProject.Mutation;
using GraphQLTestWebProject.Query;
using GraphQLTestWebProject.Schemas;
using GraphQLTestWebProject.Services;
using GraphQLTestWebProject.Type;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IUserService, UserService>();


builder.Services.AddTransient<UserType>();
builder.Services.AddTransient<AddressType>();
builder.Services.AddTransient<UserQuery>();
builder.Services.AddTransient<UserMutation>();
builder.Services.AddTransient<ISchema, UserSchema>();
builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson();

//Db Context
builder.Services.AddDbContext<GraphQLDbContext>(option =>
{
    option.UseSqlServer(@"Server=RAHUL\SQLEXPRESS;Database=GraphQLTestDb;Trusted_Connection=True;User Id=Rahul\rahul; Password=386741; TrustServerCertificate=True");

    //Connection String Syntax
    //Server=*************;Database=*************;Trusted_Connection=True;User Id=R*************; Password=*************; TrustServerCertificate=True
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;

    // Get your DbContext instance
    var dbContext = serviceProvider.GetRequiredService<GraphQLDbContext>();

    // Ensure the database is created
    dbContext.Database.EnsureCreated();
}

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//app.UseAuthorization();

//app.MapControllers();

app.UseGraphQLGraphiQL("/graphql");
app.UseGraphQL<ISchema>();

app.Run();


/// <description>
/// For GraphQL Explorer
/// GraphQL.Server.Ui.GraphiQL
/// 
/// For Getting GraphQL data in JSON Structure
/// GraphQL.Server.Transports.AspNetCore.SystemTextJson
/// 
/// For Entity Framework
/// Microsoft.EntityFrameworkCore
/// 
/// For Connecting to SQL Server
/// Microsoft.EntityFrameworkCore.SqlServer
/// </description>
