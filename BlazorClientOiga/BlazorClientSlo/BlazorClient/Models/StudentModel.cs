namespace BlazorClient.Models;

public class StudentModel
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? Active { get; set; }
}
