using SharedKernel.Enums;

namespace SharedKernel.Base
{
    public class BaseStatusReturn
    {
        public string DataResponse { get; set; }
        public string Mensagem { get; set; }
        public EnumStatus Status { get; set; }

        public BaseStatusReturn(string data, string mensagem, EnumStatus status)
        {
            DataResponse = data;
            Mensagem = mensagem;
            Status = status;
        }

        public BaseStatusReturn(dynamic retorno)
        {
            DataResponse = retorno.DataResponse;
            Mensagem = retorno.Mensagem;
            Status = (EnumStatus)retorno.Status;
        }

        public void Dispose()
        {
            DataResponse = null;
            Mensagem = null;
        }

    }
}
