using SharedKernel.Base;

namespace UseCases.Sessao
{
    public partial class SessoesController: BaseUseCase
    {
        public SessoesController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
