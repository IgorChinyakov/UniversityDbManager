namespace Manager.Infrastructure.Entities;

public class Faculty
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Number { get; set; }
    
    public List<Department> Departments { get; set; }
}