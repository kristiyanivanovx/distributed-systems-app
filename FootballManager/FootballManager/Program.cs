
using FM.Services.Implementations;
using FM.Services.Interfaces;
using FM.Services.Implementations;
using FM.Services.Interfaces;
//using FM.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;


namespace FM.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name ?? "wrong name";
            //builder.Services.AddDbContext<FootballersDbContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly(assemblyName)));

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                // using System.Reflection;
                var xmlFilename = $"{assemblyName}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            string tokenTokey = builder.Configuration["Authentication:TokenKey"] ?? "Not working key";
            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(tokenTokey)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };
            });

            //builder.Services.AddScoped<IOurService, OurService>();
            builder.Services.AddAuthorization();
            builder.Services.AddSingleton<IJWTAuthenticationsManager>(new JWTAuthenticationsManager(tokenTokey));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
