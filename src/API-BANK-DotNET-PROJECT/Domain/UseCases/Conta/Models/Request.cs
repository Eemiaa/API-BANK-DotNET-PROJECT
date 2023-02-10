namespace Conta.Models
{
    public class requestConta
    {
        public class ClientePayload
        {
            public string nome_completo { get; set; }
            public DateTime data_nascimento { get; set; }
            public string email { get; set; }
            public string cpf { get; set; }
        }
        public class ContaPayload
        {
            public string senha { get; set; }
            public bool clienteExistente { get; set; }
        }
    }
}
