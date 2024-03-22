#pragma warning disable CA1506 // Избегать чрезмерной взаимозависимости классов
using Itmo.Dev.Platform.Common.Extensions;
using Itmo.Dev.Platform.Logging.Extensions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SurveyPlatform.Application.Extensions;
using SurveyPlatform.Infrastructure.Persistence.Extensions;
using SurveyPlatform.Presentation.Http.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

builder.Services.AddOptions<JsonSerializerSettings>();
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<JsonSerializerSettings>>().Value);

builder.Services.AddInfrastructurePersistence(builder.Configuration);
builder.Services.AddConnection(builder.Configuration);
builder.Services.AddApplication();

builder.Services
    .AddControllers()
    .AddNewtonsoftJson()
    .AddPresentationHttp();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.AddPlatformSerilog(builder.Configuration);
builder.Services.AddUtcDateTimeProvider();

builder.Services.AddAutoMapper(typeof(Program));

WebApplication app = builder.Build();

app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

await app.RunAsync();
#pragma warning restore CA1506 // Избегать чрезмерной взаимозависимости классов