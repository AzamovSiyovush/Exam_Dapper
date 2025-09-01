using System;

namespace Domain.Entities;

public class School
{
    public int SchoolId { get; set; }
    public string SchoolTitle { get; set; }
    public int LevelCount { get; set; }
    public int IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
