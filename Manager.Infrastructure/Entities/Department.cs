namespace Manager.Infrastructure.Entities;

public class Department
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Number { get; set; }
    public Guid FacultyId { get; set; }
    
    public Faculty Faculty { get; set; }

    public List<Lecturer> Lecturers { get; set; }
    public List<Group> Groups { get; set; }
    public List<ClassRoom> ClassRooms { get; set; }
}