using SharedKernel.Enums;

namespace SharedKernel.Base
{
    public class BaseStatusReturn
    {
        public string DataResponse { get; set; }
        public string Mensagem { get; set; }
        public EnumStatus Status { get; set; }

        public BaseStatusReturn(dynamic retorno)
        {
            DataResponse = retorno.DataResponse;
            Mensagem = retorno.Mensagem;
            Status = (EnumStatus)retorno.Status;
        }

        public BaseStatusReturn()
        {
            DataResponse = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Status = EnumStatus.SUCESSO;
            Mensagem = "";
        }

        public BaseStatusReturn Erro(string mensagem)
        {
            Mensagem = mensagem;
            Status = EnumStatus.NEGOCIO;
            return this;
        }

        public BaseStatusReturn ErroSistema(string mensagem)
        {
            Mensagem = mensagem;
            Status = EnumStatus.SISTEMA;
            return this;
        }

        public BaseStatusReturn Sucesso(string mensagem = "")
        {
            Mensagem = mensagem;
            Status = EnumStatus.SUCESSO;
            return this;
        }

        public void Dispose()
        {
            DataResponse = null;
            Mensagem = null;
        }

    }
}
