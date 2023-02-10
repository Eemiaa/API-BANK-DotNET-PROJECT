using UseCases.Conta;
using Conta.Models;
namespace Routes
{
    public static class Endpoints
    {
        public static void AddEndpoints(this WebApplication app, IServiceProvider serviceProvider)
        {
            app.UseRouting();

            app.MapPost("/CDB/v1/criarConta", (requestConta request, HttpRequest ctxReq) =>
            (serviceProvider.GetRequiredService(typeof(IConta)) as IConta).efetivarCConta());

        }

    }
}
