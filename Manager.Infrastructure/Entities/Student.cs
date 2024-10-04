namespace Manager.Infrastructure.Entities;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid GroupId { get; set; }
    
    public Group Group { get; set; }
}