using System.Xml.Serialization;

namespace Manager.Infrastructure.Entities;

public class Subject
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    
    public List<Lecturer> Lecturers { get; set; }
    
    public List<Schedule> Schedules { get; set; }
}