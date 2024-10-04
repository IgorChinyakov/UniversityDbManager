namespace Manager.Infrastructure.Entities;

public class Lecturer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string AcademicTitle { get; set; }
    public Guid DepartmentId { get; set; }
    
    public Department Department { get; set; }

    public List<Subject> Subjects { get; set; }
    public List<Schedule> Schedules { get; set; }
}