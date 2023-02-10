using SharedKernel.Base;

namespace SharedKernel.Models
{
    public record Contas
    {
        public int id { get; set; }
        public int idClinte { get; set; }
        public string conta { get; set; }
        public string password { get; set; }
        public double saldo { get; set; }
        public BaseDatas datas { get; set; }
    }
}
