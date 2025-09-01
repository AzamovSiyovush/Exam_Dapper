using System;

namespace Domain.Entities;

public class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
    public int SubjectId { get; set; }
    public int TeacherId { get; set; }
    public int ClassroomId { get; set; }
    public string Section { get; set; }
    public DateTime CreatedAt = DateTime.Now;
    public DateTime UpdatedAt = DateTime.Now;
}
