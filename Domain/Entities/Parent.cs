using System;

namespace Domain.Entities;

public class Parent
{
    public int SchoolId { get; set; }
    public string ParentCode { get; set; }
    public string ParentFullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime CreatedAt = DateTime.Now;
    public DateTime UpdatedAt = DateTime.Now;
}
