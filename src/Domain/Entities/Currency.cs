namespace Domain.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}