using Hotels.Application.Features.CQRS.Handlers.AboutHandler;
using Hotels.Application.Features.CQRS.Handlers.BannerHandler;
using Hotels.Application.Features.CQRS.Handlers.HotelHandler;
using Hotels.Application.Features.CQRS.Handlers.HotelTypeHandler;
using Hotels.Application.Interfaces;
using Hotels.Application.Interfaces.HotelInterfaces;
using Hotels.Application.Services;
using Hotels.Persistence.Context;
using Hotels.Persistence.Repositories;
using Hotels.Persistence.Repositories.HotelRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<HotelContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddScoped(typeof(IHotelRepository),typeof(HotelRepository));

builder.Services.AddScoped<GetAboutByIdQuery>();
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();


builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();

builder.Services.AddScoped<GetHotelByIdQueryHandler>();
builder.Services.AddScoped<GetHotelQueryHandler>();
builder.Services.AddScoped<CreateHotelCommandHandler>();
builder.Services.AddScoped<UpdateHotelCommandHandler>();
builder.Services.AddScoped<RemoveHotelCommandHandler>();
builder.Services.AddScoped<GetHotelWithHotelTypeQueryHandler>();

builder.Services.AddScoped<GetHotelTypeByIdQueryHandler>();
builder.Services.AddScoped<GetHotelTypeQueryHandler>();
builder.Services.AddScoped<CreateHotelTypeCommandHandler>();
builder.Services.AddScoped<UpdateHotelTypeCommandHandler>();
builder.Services.AddScoped<RemoveHotelTypeCommandHandler>();

builder.Services.AddControllers();

builder.Services.AddApplication(builder.Configuration);//mediatr ile yönetilen kýsým, registiration dosyasýna buradan ulaþýyor

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
