namespace MonthlyBillsWebAPI.Models2.DTO
{
    public class MonthlyBillsDto
    {
        public MonthlyBillsDto
        {
        }

        public int Id { get; set; }
        public string Bill { get; set; }
        public float? Cost { get; set; }
        public string Date { get; set; }
        public string BillAlias { get; set; }
        public string UserId { get; set; }

    }
}
