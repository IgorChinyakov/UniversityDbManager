namespace Manager.Infrastructure.Entities;

public class Group
{
    public Guid Id { get; set; }
    public string Number { get; set; }
    public Guid DepartmentId { get; set; }
    
    public Department Department { get; set; }
    
    public List<Student> Students { get; set; }
    public List<Schedule> Schedules { get; set; }
}