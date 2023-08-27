using GraphQL.Server;
using GraphQL.Types;
using GraphQLTestWebProject.Interfaces;
using GraphQLTestWebProject.Mutation;
using GraphQLTestWebProject.Query;
using GraphQLTestWebProject.Schemas;
using GraphQLTestWebProject.Services;
using GraphQLTestWebProject.Type;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IUserService, UserService>();


builder.Services.AddSingleton<UserType>();
builder.Services.AddSingleton<UserQuery>();
builder.Services.AddSingleton<UserMutation>();
builder.Services.AddSingleton<ISchema,UserSchema>();
builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
