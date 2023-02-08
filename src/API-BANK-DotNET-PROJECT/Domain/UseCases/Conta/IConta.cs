using SharedKernel.Base;

namespace UseCases.Conta
{
    public interface IConta
    {
        bool digitosIguais(string senha);
        //ValueTask<BaseStatusReturn> validarDadosCliente(transaction);
    }
}
