using SharedKernel.Base;

namespace UseCases.Conta
{
    public partial class criarContaUsuarioInexistente: BaseUseCase
    {
        public criarContaUsuarioInexistente(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
