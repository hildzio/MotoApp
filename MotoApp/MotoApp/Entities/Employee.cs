namespace MotoApp.Entities
{
    public class Employee : EntityBase
    {
        public string? FirstName { get; set; }
        // ? znaczy że zmienna może być null    
        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";
    }
}
