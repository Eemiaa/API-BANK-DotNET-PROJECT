using SharedKernel.Base;

namespace UseCases.Conta
{
    public interface IConta
    {
        bool digitosIguais();
        ValueTask<BaseStatusReturn> validarCliente();
        ValueTask<BaseStatusReturn> validarConta();
        ValueTask<BaseStatusReturn> efetivarCConta();

    }
    public partial class criarConta : BaseUseCase, IConta
    {
        public criarConta(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
        public bool digitosIguais()
        {
            return true;
        }
        public async ValueTask<BaseStatusReturn> validarCliente()
        {
            return new BaseStatusReturn().Sucesso();
        }
        public async ValueTask<BaseStatusReturn> validarConta()
        {
            return new BaseStatusReturn().Sucesso();
        }
        public async ValueTask<BaseStatusReturn> efetivarCConta()
        {
            return new BaseStatusReturn().Sucesso();
        }

    }
}
