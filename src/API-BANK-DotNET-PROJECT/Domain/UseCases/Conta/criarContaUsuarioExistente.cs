using SharedKernel.Base;

namespace UseCases.Conta
{
    public partial class criarContaUsuarioExistente : BaseUseCase
    {
        public criarContaUsuarioExistente(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
