namespace CQRS.Domain.Request
{
    public class AddPersonRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }
    }
}
