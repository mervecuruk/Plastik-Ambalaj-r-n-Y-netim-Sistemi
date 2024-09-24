using ApplicationLayer.Mapper;
using ApplicationLayer.Services.CategoryService;
using ApplicationLayer.Services.OfferCartMessageService;
using ApplicationLayer.Services.OfferCartService;
using ApplicationLayer.Services.ProductService;
using ApplicationLayer.Services.RoleService;
using ApplicationLayer.Services.UserService;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Contexts;
using InfrastructureLayer.Repositories.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //ILogger
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddControllers().AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); // Loop a girersek bu kodu eklememiz gerekiyor.!!!!!!!

            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

            builder.Services.AddAutoMapper(x => x.AddProfile(typeof(Mapping)));

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IOfferCartRepository, OfferCartRepository>();
            builder.Services.AddScoped<IOfferCartMessageRepository, OfferCartMessageRepository>();


            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IOfferCartService, OfferCartService>();
            builder.Services.AddScoped<IOfferCartMessageService, OfferCartMessageService>();

            //ILogger
            builder.Services.AddLogging();

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

    }
}
