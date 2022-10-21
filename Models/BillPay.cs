using Dapper.Contrib.Extensions;

namespace Contas.Models
{
    [Table("[BillPay]")]
    public class BillPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Value { get; set; }
    }
}