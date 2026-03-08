using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using SwimmingAcademy.Filters;

namespace SwimmingAcademy.Extensions
{
    public static class WebApiServicesExtensions
    {
        public static IServiceCollection AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("FrontPolicy", builder =>
                {
                    builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
                });
            });

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(swagger =>
            {

                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Swimming_Academy",
                    Description = "Swimming Academy Management API"
                });

                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
                });

                swagger.OperationFilter<SecurityRequirementsOperationFilter>();
            });


            return services;
        }
    }
}
