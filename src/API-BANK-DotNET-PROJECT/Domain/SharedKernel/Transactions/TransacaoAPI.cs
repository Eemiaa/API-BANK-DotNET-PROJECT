using SharedKernel.Base;
using static Conta.Models.requestConta;

namespace SharedKernel.Transactions
{
    public class TransacaoAPI
    {
        public ClientePayload clienteDados { get; set; }
        public ContaPayload contaDados { get; set; }
        public BaseDatas datas { get; set; }
        public string tokenTransacao { get; set; }
    }
}
