using SharedKernel.Base;

namespace UseCases.Consulta
{
    public partial class consultarSaldo: BaseUseCase
    {
        public consultarSaldo(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
