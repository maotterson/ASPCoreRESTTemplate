namespace ASPCoreREST.Models
{
    public record Person
    {
        public Guid id { get; init; }
        public string Name { get; init; }
    }
}
