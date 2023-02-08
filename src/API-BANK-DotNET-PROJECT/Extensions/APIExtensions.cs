namespace Extensions
{
    public static class APIExtensions
    {
        public static void RegisterAPI(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
        }
        public static void RegisterAPI(this WebApplication app)
        {
            app.UseHttpsRedirection();
        }
    }


}

