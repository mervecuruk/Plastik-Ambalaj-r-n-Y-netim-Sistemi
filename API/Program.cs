
using ApplicationLayer.Services.HeplerService;
using ApplicationLayer.Services.RoleService;
using ApplicationLayer.Services.UserService;
using DomainLayer.Entities.Concrete;
using InfrastructureLayer.Contexts;
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
            builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>().AddRoles<AppRole>();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            //builder.Services.AddSwaggerGen();
            //***********************************************************JWT ÝÇÝN JWT ÝÇÝN JWT ÝÇÝN**********************************************************************
            //*****************************************************************************************************************************************************************
            //*****************************************************************************************************************************************************************
            var jwtSettings = builder.Configuration.GetSection("JWT");
            var scretKey = jwtSettings["Key"];

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
            {
                // JWT Doðrulamasýný yapýlandýrmak
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings["Issuer"],
                ValidAudience = jwtSettings["Audience"],
                ClockSkew = TimeSpan.FromMinutes(30),
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(scretKey))
            });

            // AutoMapper
            //builder.Services.AddAutoMapper(typeof(Microsoft.AspNetCore.Components.Forms.Mapping));

            // SERVICE
            builder.Services.AddScoped<MyTokenService>();

            //*****************************************************************************************************************************************************************
            //*****************************************************************************************************************************************************************
            //*****************************************************************************************************************************************************************
            builder.Services.AddSwaggerGen(opt =>
            {
                opt.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Insert JWT Token",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                opt.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            //builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));
          
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
