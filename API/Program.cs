using ApplicationLayer.Mapper;
using ApplicationLayer.Services.BlogService;
using ApplicationLayer.Services.CategoryService;
using ApplicationLayer.Services.JwtService;
using ApplicationLayer.Services.LogService;
using ApplicationLayer.Services.OfferCartMessageService;
using ApplicationLayer.Services.OfferCartService;
using ApplicationLayer.Services.ProductService;
using ApplicationLayer.Services.RoleService;
using ApplicationLayer.Services.SssService;
using ApplicationLayer.Services.UserService;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Contexts;
using InfrastructureLayer.Repositories.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
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

            // CORS politikasý ekleyelim
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigins", builder =>
                {
                    builder.WithOrigins("https://mvc20240918115122.azurewebsites.net") // Frontend'in URL'sini buraya ekleyin
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            // Add services to the container.

            builder.Services.AddControllers();

            //ILogger
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddDbContext<LogDbContext>();

            builder.Services.AddControllers().AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); // Loop a girersek bu kodu eklememiz gerekiyor.!!!!!!!

            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            // appsettings.json'dan JwtSettings'i DI konteynerine ekleyin
            builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));

            // JWT konfigürasyonu
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                };
            });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
                options.AddPolicy("ContentManagerOnly", policy => policy.RequireRole("ContentManager"));
                options.AddPolicy("CustomerServiceOnly", policy => policy.RequireRole("CustomerService"));
                options.AddPolicy("VisitorOnly", policy => policy.RequireRole("Visitor"));
            });


            //*****************************************JWT END***********************//

            builder.Services.AddAutoMapper(x => x.AddProfile(typeof(Mapping)));

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IOfferCartRepository, OfferCartRepository>();
            builder.Services.AddScoped<IOfferCartMessageRepository, OfferCartMessageRepository>();
            builder.Services.AddScoped<IBlogRepository, BlogRepository>();
            builder.Services.AddScoped<ILogRepository, LogRepository>();
            builder.Services.AddScoped<ISssRepository, SssRepository>();
            builder.Services.AddScoped<JwtService>();


            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IOfferCartService, OfferCartService>();
            builder.Services.AddScoped<IOfferCartMessageService, OfferCartMessageService>();
            builder.Services.AddScoped<IBlogService, BlogService>();
            builder.Services.AddScoped<ILogService, LogService>();
            builder.Services.AddScoped<ISssService, SssService>();

            //ILogger
            builder.Services.AddLogging();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseCors("AllowSpecificOrigins"); // CORS politikasýný kullan

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

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowSpecificOrigins"); // CORS politikasýný burada uyguluyoruz

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }



    }
}
