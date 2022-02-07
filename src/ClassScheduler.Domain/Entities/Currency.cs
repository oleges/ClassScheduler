namespace ClassScheduler.Domain.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ICollection<Price> Prices { get; set; }
    }
}