namespace Routes
{
    public static class Endpoints
    {
        public static void AddEndpoints(this WebApplication app, IServiceProvider serviceProvider)
        {
            app.UseRouting();
            app.MapPost("/CDB/v1/validarAplicacao", () =>
            (serviceProvider.GetRequiredService(typeof()));

            app.MapPost("/CDB/v1/efetivarAplicacao", () =>
            (serviceProvider.GetRequiredService());

        }

    }
}
