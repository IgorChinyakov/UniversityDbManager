namespace Manager.Infrastructure.Entities;

public class Schedule
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public Guid SubjectId { get; set; }
    public Guid LecturerId { get; set; }
    public Guid ClassRoomId { get; set; }
    public DateTime Time { get; set; }

    public Group Group { get; set; }
    public Subject Subject { get; set; }
    public Lecturer Lecturer { get; set; }
    public ClassRoom ClassRoom { get; set; }
}