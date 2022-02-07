namespace ClassScheduler.Domain.Entities
{
    public class Price
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset? End { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}