using SharedKernel.Base;

namespace UseCases.SessaoController
{
    public partial class sessaoLogout: BaseUseCase
    {
        public sessaoLogout(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
