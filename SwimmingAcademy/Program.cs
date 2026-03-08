using SwimmingAcademy.Extensions;

namespace SwimmingAcademy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region DI Container
            //WebApi Services
            builder.Services.AddWebApiServices(builder.Configuration);

            //Infrastructure Services
            builder.Services.AddInfrastructureServices(builder.Configuration);

            #endregion

            var app = builder.Build();

            #region Middlewares

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwaggerMiddleware();
            //}

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors("FrontPolicy");
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
            #endregion
        }
    }
}
