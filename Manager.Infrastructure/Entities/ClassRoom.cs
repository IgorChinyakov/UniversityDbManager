namespace Manager.Infrastructure.Entities;

public class ClassRoom
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public Guid DepartmentId { get; set; }
    
    public Department Department { get; set; }
    
    public List<Schedule> Schedules { get; set; }
}