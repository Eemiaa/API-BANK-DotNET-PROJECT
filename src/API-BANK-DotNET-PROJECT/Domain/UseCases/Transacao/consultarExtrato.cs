using SharedKernel.Base;

namespace UseCases.Consulta
{
    public partial class consultarExtrato: BaseUseCase
    {
        public consultarExtrato(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
