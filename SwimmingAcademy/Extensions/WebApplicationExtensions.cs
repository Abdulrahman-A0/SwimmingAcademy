namespace SwimmingAcademy.Extensions
{
    public static class WebApplicationExtensions
    {
        public static WebApplication UseSwaggerMiddleware(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            return app;
        }
    }
}
