using System;

namespace Domain.Entities;

public class StudentParent
{
    public int StudentParentId { get; set; }
    public int StudentId { get; set; }
    public int ParentId { get; set; }
    public int Relationship { get; set; }
}
