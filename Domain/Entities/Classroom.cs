using System;

namespace Domain.Entities;

public class Classroom
{
    public int ClassroomId { get; set; }
    public int Capacity { get; set; }
    public int RoomType { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt = DateTime.Now;
    public DateTime UpdatedAt = DateTime.Now;
}
